using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.두_정수_사이의_합
{
    class Solution
    {
        public long solution(int a, int b)
        {
            // a == b인 경우 계산하지 않음
            if (a == b)
                return 0;

            // b가 큰 수
            if (a > b)
            {
                a ^= b; b ^= a; a ^= b;
            }

            // 부호가 다른 경우, 중복되지 않는 부분만 계산
            if (a * b < 0)
                if (Math.Abs(a) > Math.Abs(b))
                    b = (b + 1) * -1;
                else
                    a = (a - 1) * -1;

            return (long)b * (b + 1) / 2 - (long)a * (a - 1) / 2;
        }
    }
}
