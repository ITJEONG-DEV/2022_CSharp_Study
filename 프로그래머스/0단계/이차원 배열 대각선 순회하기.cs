using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.이차원_배열_대각선_순회하기
{
    public class Solution
    {
        public int solution(int[,] board, int k)
        {
            int result = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (i + j <= k)
                    {
                        result += board[i, j];
                    }
                }
            }

            return result;
        }
    }
}
