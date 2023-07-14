using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.점_찍기
{
    public class Solution
    {
        public long solution(int k, int d)
        {
            long count = 0;

            double c = Math.Pow(d, 2) / Math.Pow(k, 2);
            for(int x=0; x<=d/k; x++)
            {

                count += (int)Math.Sqrt(Math.Abs(c - Math.Pow(x, 2)));
            }

            return count;
        }
    }
}
