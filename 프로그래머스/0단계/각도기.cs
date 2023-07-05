using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.각도기
{
    public class Solution
    {
        public int solution(int angle)
        {
            if (0 < angle && angle < 90) return 1;
            if (angle == 90) return 2;
            if (90 < angle && angle < 180) return 3;
            return 4;
        }
    }
}
