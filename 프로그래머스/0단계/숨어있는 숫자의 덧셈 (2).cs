using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 프로그래머스.숨어있는_숫자의_덧셈_2
{
    public class Solution
    {
        public int solution(string my_string)
        {
            int sum = 0;

            int n = 0;
            foreach(char c in my_string)
            {
                if(c >= '0' && c <= '9')
                {
                    if(n>0)
                    {
                        n *= 10;
                    }
                    n += c - '0';
                }
                else
                {
                    sum += n;
                    n = 0;
                }
            }

            sum += n;

            return sum;
        }
    }
}
