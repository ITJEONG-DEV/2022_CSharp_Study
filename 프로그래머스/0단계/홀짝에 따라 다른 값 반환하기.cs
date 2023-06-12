using System;

namespace 프로그래머스.홀짝에_따라_다른_값_반환하기
{
    public class Solution
    {
        public int evenSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }

            return sum;
        }
        public int squareOddSum(int n)
        {
            int sum = 0;
            for (int i = 2; i <= n; i += 2)
            {
                sum += i * i;
            }

            return sum;
        }
        public int solution(int n)
        {
            return n % 2 == 0 ? squareOddSum(n) : evenSum(n);
        }
    }
}
