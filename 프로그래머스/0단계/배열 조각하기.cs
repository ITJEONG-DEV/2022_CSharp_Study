using System;
using System.Collections.Generic;

namespace 프로그래머스.배열_조각하기
{
    public class Solution
    {
        public int[] solution(int[] arr, int[] query)
        {
            List<int> result = new List<int>();
            result.AddRange(arr);

            for (int i = 0; i < query.Length; i++)
            {
                Console.WriteLine(String.Join(" ", result));
                
                if (i % 2 == 0)
                {
                    var count = result.Count - (query[i]+1);
                    result.RemoveRange(query[i]+1, count);
                }
                else
                {
                    result.RemoveRange(0, query[i]);
                }
            }

            return result.ToArray();
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine(String.Join(" ", solution.solution(new int[] { 0, 1, 2, 3, 4, 5 }, new int[] { 4, 1, 2 })));
        }
    }
}
