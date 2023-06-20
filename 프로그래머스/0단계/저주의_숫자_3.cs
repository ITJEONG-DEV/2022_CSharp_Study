using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.저주의_숫자_3
{
    public class Solution
    {
        public bool contain3(int n)
        {
            int t = n;
            while (t != 0)
            {
                if (t % 10 == 3)
                {
                    return true;
                }
                t = t / 10;
            }

            return false;
        }
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 0; i < n; i++)
            {
                answer++;

                while (true)
                {
                    if (answer % 3 == 0 || contain3(answer))
                    {
                        answer++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return answer;
        }
    }
}
