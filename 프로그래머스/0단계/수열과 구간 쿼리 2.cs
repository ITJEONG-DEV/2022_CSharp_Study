using System;
using System.Linq;

namespace 프로그래머스.수열과_구간_쿼리_2
{
    public class Solution
    {
        public int[] solution(int[] arr, int[,] queries)
        {

            int[] answer = new int[queries.GetLength(0)];

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = -1;

                int s = queries[i, 0];
                int e = queries[i, 1];
                int k = queries[i, 2];

                var target = arr.Skip(s).Take(e - s + 1).ToArray();
                Array.Sort(target);

                for (int j = 0; j < target.Length; j++)
                {
                    if (target[j] > k)
                    {
                        answer[i] = target[j];
                        break;
                    }
                }

            }

            return answer;
        }
    }
}
