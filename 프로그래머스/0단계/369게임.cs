using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스._369게임
{
    public class Solution
    {
        public int solution(int order)
        {
            int count = 0;

            while (order > 0)
            {
                if (order % 10 == 3 || order % 10 == 6 || order % 10 == 9)
                {
                    count++;
                }

                order /= 10;
            }

            return count;
        }
    }
}
