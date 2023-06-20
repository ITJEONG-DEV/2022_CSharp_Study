using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.정사각형으로_만들기
{
    public class Solution
    {
        public int[,] solution(int[,] arr)
        {
            int width = arr.GetLength(1);
            int height = arr.GetLength(0);

            if (width == height)
                return arr;

            else
            {
                if (width > height)
                {
                    int[,] result = new int[width, width];

                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            result[i, j] = arr[i, j];
                        }
                    }

                    return result;
                }

                else
                {
                    int[,] result = new int[height, height];

                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            result[i, j] = arr[i, j];
                        }
                    }

                    return result;
                }
            }
        }
    }
}
