using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.콜라츠_추측
{
    class Solution
    {
        public int solution(int num)
        {
            int count = 0;

            long target = (long)num;
            while(target != 1)
            {
                if (count > 500)
                    return -1;

                if (target % 2 == 0)
                    target /= 2;
                else
                    target = target * 3 + 1;

                count++;
            }
            return count;
        }
    }
}
