using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.다음_큰_숫자
{
    class Solution
    {
        public int Get1Count(int n)
        {
            string str = Convert.ToString(n, 2);

            int count = 0;
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == '1') count++;
            }
            return count;
        }
        public int solution(int n)
        {

            int target_count = Get1Count(n);

            int m = n + 1;
            while (target_count != Get1Count(m))
            {
                m++;
            }

            return m;
        }
    }
}
