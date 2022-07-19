using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.정수_내림차순으로_배치하기
{
    class Solution
    {
        public long solution(long n)
        {
            List<int> list = new List<int>();

            while(n>0)
            {
                list.Add((int)(n % 10));
                n /= 10;
            }

            var result = list.OrderBy((x)=>x).Reverse().ToArray();

            long answer = 0;
            for(int i= 0; i < result.Length; i++)
            {
                answer *= 10;
                answer += result[i];
            }

            return answer;
        }
    }
}
