using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.프로그래머스._0단계
{
    public class Solution
    {
        public int solution(int[] array, int n)
        {
            int differ = int.MaxValue;
            int result = -1;
            foreach (int num in array)
            {
                int d = n - num;

                if(Math.Abs(differ) == Math.Abs(d))
                {
                    result = result < num ? result : num;
                }
                else if(Math.Abs(differ) > Math.Abs(d))
                {
                    result = num;
                    differ = d;
                }
            }

            return result;
        }
    }
}
