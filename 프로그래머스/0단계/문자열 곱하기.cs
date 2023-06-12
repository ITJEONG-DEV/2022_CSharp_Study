using System;
using System.Text;
using System.Linq;

namespace 프로그래머스.문자열_곱하기
{
    public class Solution
    {
        public string solution(string my_string, int k)
        {
            var result = new StringBuilder();

            for (int i = 0; i < k; i++)
            {
                result.Append(my_string);
            }

            return result.ToString();
        }
    }
}
