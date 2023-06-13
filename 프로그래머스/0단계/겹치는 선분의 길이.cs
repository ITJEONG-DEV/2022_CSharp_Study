using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.겹치는_선분의_길이
{
    public class Solution
    {
        public int solution(int[,] lines)
        {
            int[] arr = new int[201];

            for (int i = 0; i < lines.GetLength(0); i++)
            {
                for (int j = lines[i, 0]; j < lines[i, 1]; j++)
                {
                    arr[j + 100] += 1;
                }
            }

            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 1)
                {
                    result += 1;
                }
            }

            return result;
        }
    }
}
