using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.치킨_쿠폰
{
    public class Solution
    {
        public int solution(int chicken)
        {
            int result = 0;

            while (chicken >= 10)
            {
                result += chicken / 10;
                chicken = chicken / 10 + chicken % 10;
            }

            return result;
        }
    }
}
