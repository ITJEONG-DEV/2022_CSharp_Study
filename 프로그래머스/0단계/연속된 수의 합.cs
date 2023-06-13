using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.연속된_수의_합
{
    public class Solution
    {
        public int[] solution(int num, int total)
        {
            int[] answer = new int[num];

            int start = total / num - (num - 1) / 2;

            for (int i = 0; i < num; i++)
            {
                answer[i] = start + i;
            }

            return answer;
        }
    }
}
