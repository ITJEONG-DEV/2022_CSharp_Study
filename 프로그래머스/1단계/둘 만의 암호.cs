using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.둘_만의_암호
{
    public class Solution
    {
        public string solution(string s, string skip, int index)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                for (int j = 1; j <= index; j++)
                {
                    c++;

                    if (c > 'z')
                    {
                        c = 'a';
                    }

                    while (skip.Contains(c))
                    {
                        c++;

                        if (c > 'z')
                        {
                            c = 'a';
                        }
                    }
                }
               result += c;
            }
            return result;
        }
    }
}
