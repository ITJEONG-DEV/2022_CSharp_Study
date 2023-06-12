using System;

namespace 프로그래머스.카운트_업
{
    public class Solution
    {
        public int[] solution(int start, int end)
        {
            int[] answer = new int[end - start + 1];

            for (int i = start; i <= end; i++)
            {
                answer[i - start] = i;
            }

            return answer;
        }
    }
}
