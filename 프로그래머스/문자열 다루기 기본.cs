using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열_다루기_기본
{
    class Solution
    {
        public bool solution(string s)
        {
            if (!(s.Length == 4 || s.Length == 6))
                return false;

            for (int i = 0; i < s.Length; i++)
                if (s[i] >= '0' && s[i] <= '9')
                    continue;
                else
                    return false;
            return true;
        }
    }
}
