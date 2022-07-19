using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.약수의_합
{
    class Solution
    {
        public int solution(int n)
        {
            int sum = 0;
            for(int i=1; i<Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    sum += i + n / i;
            }

            if (Math.Sqrt(n) - (int)Math.Sqrt(n) == 0)
                sum += (int)Math.Sqrt(n);

            return sum;
        }
    }
}
