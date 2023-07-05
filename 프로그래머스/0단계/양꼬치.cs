using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.양꼬치
{
    public class Solution
    {
        public int solution(int n, int k)
        {
            k = k - (n / 10);
            return 12000 * n + 2000 * k;
        }
    }
}
