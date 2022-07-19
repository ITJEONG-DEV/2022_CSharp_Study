using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.평균_구하기
{
    class Solution
    {
        public double solution(int[] arr)
        {
            return (double)(arr.Sum(x => x))/arr.Count();
        }
    }
}
