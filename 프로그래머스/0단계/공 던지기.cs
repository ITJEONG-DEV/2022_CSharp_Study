using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.공_던지기
{
    public class Solution
    {
        public int solution(int[] numbers, int k)
        {
            return numbers[(k - 1) * 2 % numbers.Length];
        }
    }
}
