using System;

namespace 프로그래머스.공배수
{
    public class Solution
    {
        public int solution(int number, int n, int m)
        {
            return number % n == 0 && number % m == 0 ? 1 : 0;
        }
    }
}
