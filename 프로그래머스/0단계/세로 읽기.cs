using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.세로_읽기
{
    public class Solution
    {
        public string solution(string my_string, int m, int c)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int i = 0;
            while (my_string.Length > i * m + c - 1)
            {
                stringBuilder.Append(my_string[i * m + c - 1]);
                i++;
            }

            return stringBuilder.ToString();
        }
    }
}
