using System;
using System.Text;
using System.Linq;

namespace 프로그래머스.문자열_섞기
{
    public class Solution
    {
        public string solution(string str1, string str2)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str1.Length; i++)
            {
                result.Append(str1[i]);
                result.Append(str2[i]);
            }

            return result.ToString();
        }
    }
}
