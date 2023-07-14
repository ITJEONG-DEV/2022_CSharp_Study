using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.접미사인지_확인하기
{
    public class Solution
    {
        public int solution(string my_string, string is_suffix)
        {
            if (my_string.Length < is_suffix.Length) return 0;
            return my_string.Substring(my_string.Length - is_suffix.Length + 1) == is_suffix ? 1 : 0;
        }
    }
}
