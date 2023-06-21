using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열_뒤집기
{
    public class Solution
    {
        public string getReverseString(string s)
        {
            return string.Concat(s.Reverse());
        }
        public string solution(string my_string, int s, int e)
        {
            return (s == 0 ? "" : my_string.Substring(0, s)) + getReverseString(my_string.Substring(s, e - s + 1)) + (e == my_string.Length ? "" : my_string.Substring(e + 1));
        }
    }
}
