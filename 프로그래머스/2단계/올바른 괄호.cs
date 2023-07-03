using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.올바른_괄호
{
    public class Solution
    {
        public bool solution(string s)
        {
            if (s.Length % 2 == 1) return false;
            if (s[0] == ')') return false;
            if (s[s.Length - 1] == '(') return false;

            int left = 0;
            int right = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    left++;
                else if(left > 0)
                        left--;
                else
                    return false;
            }

            if (left == 0 && right == 0)
                return true;

            return false;
        }
    }
}
