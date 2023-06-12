using System;

namespace 프로그래머스.수_조작하기_1
{
    public class Solution
    {
        public int solution(int n, string control)
        {
            int answer = n;

            for (int i = 0; i < control.Length; i++)
            {
                switch (control[i])
                {
                    case 'w':
                        answer += 1;
                        break;
                    case 's':
                        answer -= 1;
                        break;
                    case 'd':
                        answer += 10;
                        break;
                    case 'a':
                        answer -= 10;
                        break;
                }
            }
            return answer;
        }
    }
}
