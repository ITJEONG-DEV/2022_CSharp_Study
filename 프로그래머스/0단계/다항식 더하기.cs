using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.다항식_더하기
{
    public class Solution
    {
        public string solution(string polynomial)
        {
            var words = polynomial.Split(' ');

            int x = 0;
            int a = 0;
            foreach (var word in words)
            {
                if (word.Contains("x"))
                {
                    string coefficient = word.Replace("x", "");

                    if (coefficient == "")
                    {
                        x++;
                    }
                    else
                    {
                        x += int.Parse(coefficient);
                    }
                }
                else if (!word.Contains("+"))
                {
                    a += int.Parse(word);
                }
            }

            if (x == 0)
            {
                return $"{a}";
            }
            else if (a == 0)
            {
                if (x == 1)
                {
                    return "x";
                }
                else
                {
                    return $"{x}x";
                }
            }
            else
            {
                if (x == 1)
                {
                    return $"x + {a}";
                }
                else
                {
                    return $"{x}x + {a}";
                }
            }
        }
    }
}
