using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열의_앞의_n글자
{
    public class Solution
    {
        public string solution(string my_string, int n)
        {
            return my_string.Substring(0, n);
        }
    }
}
