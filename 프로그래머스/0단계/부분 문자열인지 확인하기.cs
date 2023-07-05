using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.부분_문자열인지_확인하기
{
    public class Solution
    {
        public int solution(string my_string, string target)
        {
            if (my_string.Contains(target)) return 1;
            return 0;
        }
    }
}
