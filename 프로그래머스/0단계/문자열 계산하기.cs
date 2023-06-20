using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열_계산하기
{
    public class Solution
    {
        enum Operater
        {
            None = 0,
            Plus = 1,
            Minus =2
        }

        public int solution(string my_string)
        {
            int result = 0;
            Operater op = Operater.None;
            foreach(var word in my_string.Split(' '))
            {
                if(word == "+")
                {
                    op = Operater.Plus;
                }
                else if(word == "-")
                {
                    op = Operater.Minus;
                }
                else
                {
                    switch(op)
                    {
                        case Operater.Plus:
                            result += int.Parse(word);
                            break;
                        case Operater.Minus:
                            result -= int.Parse(word);
                            break;
                        default:
                            result = int.Parse(word);
                            break;
                    }
                }
            }

            return result;
        }
    }
}
