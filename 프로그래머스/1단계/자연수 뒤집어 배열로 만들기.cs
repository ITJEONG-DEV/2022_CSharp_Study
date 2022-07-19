using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.자연수_뒤집어_배열로_만들기
{
    class Solution
    {
        public int[] solution(long n)
        {
            List<int> answer = new List<int>();

            while(n>0)
            {
                answer.Add((int)(n%10));
                n /= 10;
            }

            return answer.ToArray();
        }
    }
}
