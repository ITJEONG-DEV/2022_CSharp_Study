using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열이_몇_번_등장하는지_세기
{
    public class Solution
    {
        public int solution(string myString, string pat)
        {
            int count = 0;

            for (int i = 0; i < myString.Length - pat.Length + 1; i++)
            {
                if (myString.Substring(i, pat.Length).Contains(pat))
                    count++;

            }

            return count;
        }
    }
}
