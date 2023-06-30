using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스._9로_나눈_나머지
{
    public class Solution
    {
        public int solution(string number)
        {
            int n = 0;
            foreach (char c in number)
            {
                n += c - '0';

                n %= 9;
            }

            return n;
        }
    }
}
