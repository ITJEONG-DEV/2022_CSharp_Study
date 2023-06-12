using System;

namespace 프로그래머스.flag에_따라_다른_값_반환하기
{
    public class Solution
    {
        public int solution(int a, int b, bool flag)
        {
            return flag ? a + b : a - b;
        }
    }
}
