using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.금과_은_운반하기
{
    public class Solution
    {
        public bool IsPossible(long time, int a, int b, int[] g, int[] s, int[] w, int[] t)
        {
            long total = 0;
            long totalG = 0;
            long totalS = 0;

            for(int i=0; i<t.Length; i++)
            {
                long count = ((long)(time / t[i]) + 1) / 2;
                long newW = Math.Min(count * w[i], g[i] + s[i]);

                total += newW;
                totalG += Math.Min(newW, g[i]);
                totalS += Math.Min(newW, s[i]);

            }

            if (total >= a + b && totalG >= a && totalS >= b) return true;
            return false;
        }

        public long solution(int a, int b, int[] g, int[] s, int[] w, int[] t)
        {
            long r = 400000000000000L;
            long l = 0;

            while(l+1<r)
            {
                long m = (l + r) / 2;

                if (IsPossible(m, a, b, g, s, w, t)) r = m;
                else l = m;
            }

            return r;
        }
    }
}
