using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.JadenCase_문자열_만들기
{
    public class Solution
    {
        public bool IsUpper(char c)
        {
            return c >= 'A' && c <= 'Z';
        }
        public bool IsLower(char c)
        {
            return c >= 'a' && c <= 'z';
        }

        public bool IsNumber(char c)
        {
            return c >= '0' && c <= '9';
        }

        public string solution(string s)
        {
            StringBuilder stringBuilder= new StringBuilder(s);

            bool first = true;
            int index = 0;
            while(index < stringBuilder.Length)
            {
                char c = stringBuilder[index];

                if (c == ' ')
                {
                    if (index>0 && IsNumber(stringBuilder[index-1]))
                    {
                        stringBuilder.Remove(index, 1);
                        index--;
                    }
                    first = true;
                }
                else
                {
                    if(first)
                    {
                        if(IsLower(c))
                            stringBuilder[index] = (char)(stringBuilder[index] - 'a' + 'A');

                        first = false;
                    }
                    else
                    {
                        if(IsUpper(c))
                            stringBuilder[index] = (char)(stringBuilder[index] - 'A' + 'a');

                        else if(IsNumber(c))
                        {
                            stringBuilder.Insert(index, ' ');
                            first = true;
                        }
                    }
                }
                index++;
            }

            return stringBuilder.ToString();
        }
    }
}
