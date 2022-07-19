using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.없는_숫자_더하기
{
    class Solution
    {
        public int solution(int[] numbers)
        {
            int answer = 0;

            for (int i = 1; i <= 9; i++) 
            {
                if (!numbers.Contains(i))
                    answer += i;
            }

            return answer;
        }
    }
}
