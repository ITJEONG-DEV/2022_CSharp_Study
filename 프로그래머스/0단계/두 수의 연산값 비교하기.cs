using System;

namespace 프로그래머스.두_수의_연산값_비교하기
{
    public class Solution
    {
        public int solution(int a, int b)
        {
            int r1 = int.Parse(a.ToString() + b.ToString());
            int r2 = 2 * a * b;

            return r1 > r2 ? r1 : r2;
        }
    }
}
