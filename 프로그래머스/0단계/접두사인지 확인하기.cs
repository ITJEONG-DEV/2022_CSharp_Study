using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.접두사인지_확인하기
{
    public class Solution
    {
        public int solution(string my_string, string is_prefix)
        {
            if (my_string.Length < is_prefix.Length) return 0;
            return my_string.Substring(0, is_prefix.Length) == is_prefix ? 1 : 0;
        }
    }
}
