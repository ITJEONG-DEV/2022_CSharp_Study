using System;

namespace 프로그래머스.주사위_게임_2
{
    public class Solution
    {
        public int solution(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return (a + b + c) * (a * a + b * b + c * c) * (a * a * a + b * b * b + c * c * c);
            }
            else if (a == b || b == c || a == c)
            {
                return (a + b + c) * (a * a + b * b + c * c);
            }
            else
            {
                return a + b + c;
            }
        }
    }
}
