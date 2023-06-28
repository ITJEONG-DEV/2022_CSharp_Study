using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스._1로_만들기
{

    public class Solution
    {
        public int solution(int[] num_list)
        {
            int count = 0;

            foreach (int num in num_list)
            {
                int n = num;
                while (n > 1)
                {
                    if (n % 2 == 0)
                    {
                        n /= 2;
                        count++;
                    }
                    else
                    {
                        n -= 1;
                        n /= 2;
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
