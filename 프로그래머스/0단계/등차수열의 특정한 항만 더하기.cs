using System;

namespace 프로그래머스.등차수열의_특정한_항만_더하기
{
    public class Solution
    {
        public int solution(int a, int d, bool[] included)
        {
            int result = 0;
            for (int i = 0; i < included.Length; i++)
            {
                if (included[i])
                {
                    result += (a + i * d);
                }
            }

            return result;
        }
    }
}