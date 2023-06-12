using System;

namespace 프로그래머스.수열과_구간_쿼리_3
{
    public class Solution
    {
        public int[] solution(int[] arr, int[,] queries)
        {

            int[] answer = (int[])arr.Clone();

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int a = answer[queries[i, 0]];
                int b = answer[queries[i, 1]];

                answer[queries[i, 0]] = b;
                answer[queries[i, 1]] = a;
            }
            return answer;
        }
    }
}
