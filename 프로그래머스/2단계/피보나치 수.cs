using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.피보나치_수
{
    public class Solution
    {
        public int Fibo(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int v = Fibo(n - 2) + Fibo(n - 1);
            if (v > 1234567)
                v -= 1234567;
            return v;
        }
        public int solution(int n)
        {
            int i = 0;

            int f2 = 0;
            int f1 = 0;
            int f = 0;
            while(i < n)
            {
                if(i==0)
                {
                    f = 0;
                }
                else if(i==1)
                {
                    f = 1;
                }

                f2 = f1;
                f1 = f;
                f = f2 + f1;
                i++;

                if (f > 1234567)
                    f -= 1234567;
            }

            return f;
        }
    }
}
