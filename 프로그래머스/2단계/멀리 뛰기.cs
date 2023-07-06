using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.멀리_뛰기
{
    public class Solution
    {
        public long solution(int n)
        {
            int i = 0;

            int f2 = 0;
            int f1 = 0;
            int f = 0;

            while(i<n)
            {
                if (i == 0) f = 0;
                else if (i == 1) f = 1;

                f2 = f1;
                f1 = f;
                f = f2 + f1;
                i++;

                f %= 1234567;
            }

            return f;
        }
    }
}
