using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.하샤드_수
{
    class Solution
    {
        public bool solution(int x)
        {
            int target = x;
            int sum = 0;
            while(target>0)
            {
                sum += target % 10;
                target /= 10;
            }

            if (x % sum == 0)
                return true;
            else
                return false;
        }
    }
}
