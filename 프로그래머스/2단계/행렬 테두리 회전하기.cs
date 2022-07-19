using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.행렬_테두리_회전하기
{
    class Solution
    {
        public int Rotate(ref int[,] matrix, ref int[,] queries, int index)
        {
            int x1 = queries[index, 0], x2 = queries[index, 2];
            int y1 = queries[index, 1], y2 = queries[index, 3];

            int tmp;
            int target = matrix[x1 - 1, y1 - 1];
            int min = target;

            for (int y = y1; y < y2; y++)
            {
                if (min > target)
                    min = target;

                tmp = matrix[x1 - 1, y];
                matrix[x1 - 1, y] = target;
                target = tmp;
            }

            for (int x = x1; x < x2; x++)
            {
                if (min > target)
                    min = target;

                tmp = matrix[x, y2 - 1];
                matrix[x, y2 - 1] = target;
                target = tmp;
            }

            for (int y = y2-2; y >= y1 - 1; y--)
            {
                if (min > target)
                    min = target;

                tmp = matrix[x2 - 1, y];
                matrix[x2 - 1, y] = target;
                target = tmp;
            }

            for (int x = x2-2; x >= x1 - 1; x--)
            {
                if (min > target)
                    min = target;

                tmp = matrix[x, y1 - 1];
                matrix[x, y1 - 1] = target;
                target = tmp;
            }

            return min;
        }
        public int[] solution(int rows, int colums, int[,] queries)
        {
            int[,] matrix = new int[rows, colums];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < colums; j++)
                    matrix[i, j] = i * colums + j + 1;

            List<int> answer = new List<int>();
            for(int i=0; i<queries.GetLength(0); i++)
                answer.Add(Rotate(ref matrix, ref queries, i));

            return answer.ToArray();
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();
            
            var result = solution.solution(6, 6, new int[,] { { 2, 2, 5, 4 }, { 3, 3, 6, 6 }, { 5, 1, 6, 3 } });

            Print(ref result);
        }

        public static void Print(ref int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0, 2} ",arr[i, j]);

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Print(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0, 2} ", arr[i]);

            Console.WriteLine();
        }
    }
}
