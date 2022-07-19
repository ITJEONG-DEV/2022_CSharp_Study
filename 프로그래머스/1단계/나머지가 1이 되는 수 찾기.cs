using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.나머지가_1이_되는_수_찾기
{
    class Solution
    {
        public int solution(int n)
        {
            n -= 1;

            for(int i=2; i<=n;i++)
            {
                if (n % i == 0)
                    return i;
            }

            return n;
        }
    }
}
