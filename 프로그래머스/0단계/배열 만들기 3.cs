using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.배열_만들기_3
{
    public class Solution
    {
        public int[] solution(int[] arr, int[,] intervals)
        {
            List<int> list = new List<int>(arr);

            List<int> result = new List<int>();
            for (int i = 0; i < intervals.GetLength(0); i++)
            {
                result.AddRange(list.GetRange(intervals[i, 0], intervals[i, 1] - intervals[i, 0] + 1));
            }

            return result.ToArray();
        }
    }
}
