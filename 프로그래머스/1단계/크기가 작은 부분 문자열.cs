using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.크기가_작은_부분_문자열
{
    public class Solution
    {
        public int solution(string t, string p)
        {
            int count = 0;

            for (int i = 0; i <= t.Length - p.Length; i++)
                if (t.Substring(i, p.Length).CompareTo(p) < 1)
                    count++;

            return count;
        }
    }
}
