using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.분수의_덧셈
{
    public class Solution
    {
        public int GCD(int x, int y)
        {
            if (x % y == 0)
            {
                return y;
            }
            else
            {
                for (int i = y / 2; i >= 2; i--)
                {
                    if (x % i == 0 && y % i == 0)
                    {
                        return i;
                    }
                }

                return 1;
            }
        }
        public int[] solution(int numer1, int denom1, int numer2, int denom2)
        {
            int numer = numer1 * denom2 + numer2 * denom1;
            int denom = denom1 * denom2;

            int gcd = GCD(numer > denom ? numer : denom, numer > denom ? denom : numer);

            return new int[2] { numer / gcd, denom / gcd };
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(1, 2, 3, 4);
            solution.solution(9, 2, 1, 3);
            solution.solution(8, 2, 8, 2);
            solution.solution(2, 8, 2, 8);
            solution.solution(1, 2, 1, 2);
            solution.solution(512, 512, 512, 512);
            solution.solution(3, 7, 4, 7);
        }
    }
}
