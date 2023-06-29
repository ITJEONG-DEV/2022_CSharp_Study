using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스._2차원으로_만들기
{
    public class Solution
    {
        public int[,] solution(int[] num_list, int n)
        {
            int length = num_list.Length;
            int height = length / n;

            int[,] result = new int[height, n];

            for (int i = 0; i < height; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = num_list[i * n + j];

            return result;
        }
    }
}
