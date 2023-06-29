using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.수열과_구간_쿼리_1
{
    public class Solution
    {
        public int[] solution(int[] arr, int[,] queries)
        {
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                for (int j = queries[i, 0]; j <= queries[i, 1]; j++)
                {
                    arr[j]++;
                }
            }

            return arr;
        }
    }
}
