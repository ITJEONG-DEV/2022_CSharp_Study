using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.기사단원의_무기
{
    public class Solution
    {
        public int GetNumOfDivisor(int n)
        {
            int count = 0;
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    if (i == n / i) count++;
                    else count += 2;
                }
            }
            return count;
        }
        public int solution(int number, int limit, int power)
        {
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                int num = GetNumOfDivisor(i);

                if (num > limit)
                {
                    result += power;
                }
                else
                {
                    result += num;
                }
            }

            return result;
        }
    }
}
