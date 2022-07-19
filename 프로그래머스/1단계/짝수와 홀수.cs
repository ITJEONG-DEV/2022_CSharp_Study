using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.짝수와_홀수
{
    class Solution
    {
        public string solution(int num)
        {
            if (num % 2 == 0)
                return "Even";
            else
                return "Odd";
        }
    }
}
