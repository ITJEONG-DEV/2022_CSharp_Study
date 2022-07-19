using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.내적
{
    class Solution
    {
        public int solution(int[] a, int[] b)
        {
            int sum = 0;
            for(int i=0; i < a.Length; i++)
                sum+= a[i]*b[i];

            return sum;
        }
    }
}
