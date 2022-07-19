using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.자릿수_더하기
{
    class Solution
    {
        public int solution(int n)
        {
            int sum = 0;
            while(n>0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }
    }
}
