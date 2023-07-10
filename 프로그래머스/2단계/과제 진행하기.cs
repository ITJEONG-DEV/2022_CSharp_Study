using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.과제_진행하기
{
    public class Solution
    {
        public class Plan
        {
            public string name;
            public int startHour;
            public int startMin;
            public int remainTime;

            public Plan(string name, string time, string remainTime)
            {
                this.name = name;
                
                var times = time.Split(':');

                this.startHour = int.Parse(times[0]);
                this.startMin = int.Parse(times[1]);

                this.remainTime = int.Parse(remainTime);
            }

            public int DifferenceOfStartTime(Plan other)
            {
                var hour = this.startHour - other.startHour;
                var min = this.startMin - other.startMin;

                return hour * 60 + min;
            }

            public int CompareTo(Plan other)
            {
                return (this.startHour - other.startHour) * 60 + (this.startMin - other.startMin);
            }

            public bool IsEarly(Plan other)
            {
                if (this.CompareTo(other) < 0) return true;

                return false;
            }
        }
        public static void main(string[] args)
        {
            Solution solution = new Solution();
            var r = solution.solution(new string[,]
                {
                    { "korean", "11:40", "30" },
                    {"english", "12:10", "20" },
                    {"math", "12:30", "40" }
                }
            );

            Console.WriteLine(String.Join(" ", r));
        }
        public string[] solution(string[,] plans)
        {
            List<string> doneWork = new List<string>();
            Stack<Plan> remainWork = new Stack<Plan>();

            List<Plan> list = new List<Plan>();
            for (int i = 0; i < plans.GetLength(0); i++)
            {
                Plan plan = new Plan(plans[i, 0], plans[i, 1], plans[i, 2]);
                list.Add(plan);
            }
            list.Sort(new Comparison<Plan>((p1, p2) => p1.CompareTo(p2)));

            // 시작하지 않은 숙제가 남은 경우
            for (int index = 0; index < list.Count - 1; index++)
            {
                Plan cur = list[index];
                Plan next = list[index + 1];

                int remainTime = next.DifferenceOfStartTime(cur);

                if (remainTime == cur.remainTime)
                {
                    doneWork.Add(cur.name);
                }
                else if (cur.remainTime > remainTime)
                {
                    cur.remainTime -= remainTime;
                    remainWork.Push(cur);
                }
                else if (cur.remainTime < remainTime)
                {
                    doneWork.Add(cur.name);
                    remainTime -= cur.remainTime;

                    // 남은 숙제가 있는 경우, 남은 시간을 남은 숙제에 사용한다
                    while (remainTime > 0 && remainWork.Count > 0)
                    {
                        Plan remain = remainWork.Peek();

                        if (remain.remainTime <= remainTime)
                        {
                            doneWork.Add(remainWork.Pop().name);
                            remainTime -= remain.remainTime;
                        }
                        else
                        {
                            remain.remainTime -= remainTime;
                            remainTime = 0;
                        }
                    }
                }
            }
            doneWork.Add(list[list.Count - 1].name);

            // 남은 숙제가 있는 경우
            while (remainWork.Count > 0)
            {
                doneWork.Add(remainWork.Pop().name);
            }

            return doneWork.ToArray();
        }
    }
}
