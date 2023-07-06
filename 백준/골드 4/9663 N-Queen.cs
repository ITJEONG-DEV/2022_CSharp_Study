using System;

namespace 백준.Gold.N_Queen
{
    public class Solution
    {
        static void main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());

            var solution = new Solution();

            Console.WriteLine(solution.solution(n));
        }
        public int SetQueen(int x, int y)
        {
            if (y == board.Length - 1) return 1;

            board[y] = x;

            int result = 0;
            for (int xx = 0; xx < board.Length; xx++)
            {
                bool ok = true;
                for (int i = 0; i < y + 1; i++)
                {
                    if (board[i] == xx)
                    {
                        ok = false;
                        break;
                    }

                    if (Math.Abs(i - (y + 1)) == Math.Abs(board[i] - xx))
                    {
                        ok = false;
                        break;
                    }
                }

                if (ok)
                    result += SetQueen(xx, y + 1);
            }

            return result;
        }
        int[] board;
        public int solution(int n)
        {
            int result = 0;

            board = new int[n];

            for (int i = 0; i < n / 2; i++)
            {
                board[0] = i;

                result += SetQueen(i, 0) * 2;
            }

            if (n % 2 == 1)
                result += SetQueen(n / 2, 0);

            return result;
        }
    }
}
