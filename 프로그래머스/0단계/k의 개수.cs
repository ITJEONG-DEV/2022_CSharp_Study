using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.프로그래머스._0단계
{
    public class Solution
    {
        public int FindNum(int n, int k)
        {
            int count = 0;
            while (n > 0)
            {
                if (n % 10 == k)
                {
                    count++;
                }
                n /= 10;
            }

            return count;
        }
        public int solution(int i, int j, int k)
        {
            int count = 0;
            for (int n = i; n <= j; n++)
            {
                count += FindNum(n, k);
            }
            return count;
        }
    }
}
