using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.약수_구하기
{
    public class Solution
    {
        public int[] solution(int n)
        {
            List<int> result = new List<int>();

            for(int i=1; i<=n; i++)
            {
                if(n%i==0)
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }
    }
}
