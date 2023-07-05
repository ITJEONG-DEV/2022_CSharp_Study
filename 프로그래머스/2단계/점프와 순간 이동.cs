using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.점프와_순간_이동
{
    class Solution
    {
        public int solution(int n)
        {
            var s = Convert.ToString(n, 2);

            int count = 0;
            for(int i=0; i<s.Length; i++) {
                if (s[i] == '1') count++;
            }

            return count;
        }
    }
}
