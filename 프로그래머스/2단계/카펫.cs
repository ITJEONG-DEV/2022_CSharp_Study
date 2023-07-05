using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.카펫
{
    public class Solution
    {
        public int[] solution(int brown, int yellow)
        {
            int total = brown + yellow;

            for(int i=3; i<=total/3; i++)
            {
                if(total % i == 0)
                {
                    int n = i > total / i ? total / i : i;
                    int m = i < total / i ? total / i : i;

                    if( (n-2)*(m-2) == yellow && (2*m+2*n-4) == brown)
                    {
                        return new int[2] { m, n };
                    }
                }
            }

            return new int[2] { -1, -1 };
        }
    }
}
