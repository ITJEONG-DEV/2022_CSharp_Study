using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.이모티콘_할인행사
{

    public class Solution
    {
        public struct Result
        {
            public int user;
            public int sales;
            public Result(int user, int sales)
            {
                this.user = user;
                this.sales = sales;
            }
        }

        public Result GetResult(int index, int[] percents, ref int[] emoticons, ref int[,] users)
        {
            if (index == emoticons.Length)
            {
                Result result = new Result();
                result.sales = 0;
                result.user = 0;

                for (int i=0; i<users.GetLength(0); i++)
                {
                    int target_percent = users[i,0];
                    int target_threshold = users[i, 1];

                    int total = 0;
                    for(int j=0; j<emoticons.Length; j++)
                        if(target_percent <= percents[j])
                            total += emoticons[j] / 100 * (100 - percents[j]);

                    if (total >= target_threshold)
                        result.user++;
                    else
                        result.sales += total;
                }

                return result;
            }

            int sales = 0;
            int user = 0;

            for (int i = 10; i <= 40; i += 10)
            {
                int[] percentArray = new int[emoticons.Length];
                for (int j = 0; j < index; j++)
                    percentArray[j] = percents[j];
                percentArray[index] = i;

                Result r = GetResult(index+1, percentArray, ref emoticons, ref users);

                if (r.user > user)
                {
                    user = r.user;
                    sales = r.sales;
                }
                else if (r.user == user && r.sales > sales)
                {
                    sales = r.sales;
                }
            }

            return new Result(user, sales);
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();
            var r = solution.solution(new int[,] { { 40, 10000 }, { 25, 10000 } }, new int[] { 7000, 9000 });
            Console.WriteLine(String.Join(" ", r));
        }

        public int[] solution(int[,] users, int[] emoticons)
        {
            Result result = GetResult(0, new int[emoticons.Length], ref emoticons, ref users);

            return new int[] {result.user, result.sales };
        }
    }
}
