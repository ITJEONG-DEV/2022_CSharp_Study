using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.행렬의_곱셈
{
    public class Solution
    {
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];

            for(int i=0; i<result.GetLength(0); i++)
            {
                for(int j=0; j<result.GetLength(1); j++)
                {
                    for(int k=0; k<arr1.GetLength(1); k++)
                    {
                        result[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }

            return result;
        }
    }
}
