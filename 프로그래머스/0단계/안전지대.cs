using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.안전지대
{
    public class Solution
    {
        public void mark(int x, int y, int[,] board)
        {
            if (board[x, y] == 0)
            {
                board[x, y] = 2;
            }
        }
        public void check(int x, int y, int[,] board)
        {
            if (x != 0 && y != 0)
            {
                mark(x - 1, y - 1, board);
            }

            if (x != 0)
            {
                mark(x - 1, y, board);
            }

            if (x != 0 && y != board.GetLength(1) - 1)
            {
                mark(x - 1, y + 1, board);
            }

            if (y != board.GetLength(1) - 1)
            {
                mark(x, y + 1, board);
            }

            if (x != board.GetLength(0) - 1 && y != board.GetLength(1) - 1)
            {
                mark(x + 1, y + 1, board);
            }

            if (x != board.GetLength(0) - 1)
            {
                mark(x + 1, y, board);
            }

            if (x != board.GetLength(0) - 1 && y != 0)
            {
                mark(x + 1, y - 1, board);
            }

            if (y != 0)
            {
                mark(x, y - 1, board);
            }

        }
        public int solution(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 1)
                    {
                        check(i, j, board);
                    }
                }
            }

            int count = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
