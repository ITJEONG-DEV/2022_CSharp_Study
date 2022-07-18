using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.음양_더하기
{
    class Solution
    {
        public int solution(int[] absolutes, bool[] signs)
        {
            int sum = 0;

            for (int i = 0; i < absolutes.Length; i++)
                sum += signs[i] ? absolutes[i] : -absolutes[i];

            return sum;
        }
    }
}
