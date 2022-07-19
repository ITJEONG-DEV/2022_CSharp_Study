using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.프린터
{
    class Solution
    {
        public int solution(int[] priorities, int location)
        {
            if (priorities.Length == 1)
                return 1;

            Queue<int> q = new Queue<int>();

            for (int i = 0; i < priorities.Length; i++)
                q.Enqueue(priorities[i]);

            int count = 0;
            while(true)
            {
                //Print(q);
                //Console.WriteLine($"location: {location}, count: {count}");

                int p = q.Dequeue();
                --location;

                if (q.Count == 0)
                    return ++count;

                if (p<q.Max())
                {
                    q.Enqueue(p);

                    if (location==-1)
                        location = q.Count - 1;

                    continue;
                }

                count++;

                if (location == -1)
                    break;
            }

            return count;
        }

        public void Print(Queue<int> q)
        {
            var list = q.ToList();

            for(int i=0; i<list.Count; i++)
                Console.Write(list[i] + " ");
            Console.WriteLine();
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();

            int[] priorities1 = new int[] { 2, 1, 3, 2 };
            int[] priorities2 = new int[] { 1, 1, 9, 1, 1, 1 };
            int[] priorities3 = new int[] { 1,1,7,1,9,1,1 };

            Console.WriteLine(solution.solution(priorities3, 1));
        }
    }
}
