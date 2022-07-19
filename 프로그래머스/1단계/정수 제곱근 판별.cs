using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.정수_제곱근_판별
{
    class Solution
    {
        public long solution(long n)
        {
            if (Math.Sqrt(n) == (long)(Math.Sqrt(n)))
                return (long)Math.Pow(Math.Sqrt(n) + 1, 2);
            else
                return -1;
        }
    }
}
