using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.약수의_개수와_덧셈
{
    class Solution
    {
        public int solution(int left, int right)
        {
            int answer = 0;

            for (int i = left; i <= right; i++)
                if (Math.Sqrt(i) > (int)Math.Sqrt(i))
                    answer+=i;
                else
                    answer-=i;

            return answer;
        }
    }
}
