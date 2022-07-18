using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.부족한_금액_계산하기
{
    class Solution
    {
        public long solution(int price, int money, int count)
        {
            long result = price * (long)(count * (count + 1) / 2) - money;

            if (result < 0)
                return 0;

            return result;
        }
    }
}
