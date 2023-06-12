using System;

namespace 프로그래머스.n의_배수
{
    public class Solution
    {
        public int solution(int num, int n)
        {
            return num % n == 0 ? 1 : 0;
        }
    }
}
