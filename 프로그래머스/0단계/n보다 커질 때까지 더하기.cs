using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.n보다_커질_때까지_더하기
{
    public class Solution
    {
        public int solution(int[] numbers, int n)
        {
            int sum = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                sum += numbers[i];

                if (sum > n) break;
            }

            return sum;
        }
    }
}
