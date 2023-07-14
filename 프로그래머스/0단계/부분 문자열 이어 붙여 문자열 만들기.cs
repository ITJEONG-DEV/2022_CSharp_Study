using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.부분_문자열_이어_붙여_문자열_만들기
{
    public class Solution
    {
        public string solution(string[] my_strings, int[,] parts)
        {
            StringBuilder stringBuilder= new StringBuilder();

            for(int i=0; i<parts.GetLength(0); i++)
            {
                stringBuilder.Append(my_strings[i].Substring(parts[i, 0], parts[i, 1] - parts[i, 0]+1));
            }

            return stringBuilder.ToString();
        }
    }
}
