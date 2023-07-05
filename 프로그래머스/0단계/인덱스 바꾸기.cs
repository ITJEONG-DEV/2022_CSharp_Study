using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.인덱스_바꾸기
{
    public class Solution
    {
        public string solution(string my_string, int num1, int num2)
        {
            char[] chars= my_string.ToCharArray();

            char tmp = chars[num1];
            chars[num1] = chars[num2];
            chars[num2] = tmp;

            return String.Join("", chars);
        }
    }
}
