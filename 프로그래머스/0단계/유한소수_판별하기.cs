using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.유한소수_판별하기
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
        public int checkFiniteDemical(int n)
        {
            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else if (n % 5 == 0)
                {
                    n /= 5;
                }
                else
                {
                    return 2;
                }
            }
            return 1;
        }
        public int solution(int a, int b)
        {
            int gcd = GCD(a > b ? a : b, a > b ? b : a);

            int denom = b / gcd;

            return checkFiniteDemical(denom);
        }
    }
}
