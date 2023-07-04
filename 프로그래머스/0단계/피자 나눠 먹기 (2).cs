using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.피자_나눠_먹기_2
{
    public class Solution
    {
        public int solution(int n)
        {
            int num = 1;
            while (true)
            {
                if (6 * num % n == 0) return num;
                num++;
            }
        }
    }
}
