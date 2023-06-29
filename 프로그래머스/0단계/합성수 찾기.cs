using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.합성수_찾기
{
    public class Solution
    {
        public bool isCompositeNumber(int n)
        {
            for(int i=2; i<=n/2; i++)
            {
                if (n % i == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public int solution(int n)
        {
            int count = 0;
            for(int i=1; i<=n; i++)
            {
                if (isCompositeNumber(i))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
