using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.다음에_올_숫자
{
    public class Solution
    {
        public int solution(int[] common)
        {
            int d1 = common[common.Length - 1] - common[common.Length - 2];
            int d2 = common[common.Length - 2] - common[common.Length - 3];

            if (d1 == d2)
            {
                return common[common.Length - 1] + d1;
            }
            else
            {
                return common[common.Length - 1] * (d1 / d2);
            }
        }
    }
}
