using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.예상_대진표
{
    class Solution
    {
        public int solution(int n, int a, int b)
        {
            int count = 0;

            while (a != b)
            {
                a = (a + 1) / 2;
                b = (b + 1) / 2;
                count++;
            }

            return count;
        }
    }
}
