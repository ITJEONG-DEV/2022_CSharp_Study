using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.홀수_vs_짝수
{
    public class Solution
    {
        public int solution(int[] num_list)
        {
            int sum1 = 0, sum2 = 0;
            for(int i=0; i<num_list.Length; i++)
            {
                if (i % 2 == 0) sum2 += num_list[i];
                else sum1 += num_list[i];
            }

            return sum1>sum2 ? sum1 : sum2;
        }
    }
}
