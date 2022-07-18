using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.예산
{
    class Solution
    {
        public int solution(int[] d, int budget)
        {
            List<int> dl = d.OrderBy(x => x).ToList();
            List<int> ok = new List<int>();
            int sum = 0;

            foreach(int x in dl)
            {
                if (sum + x <= budget)
                {
                    ok.Add(x);
                    sum = sum + x;
                }
                else break;
            }

            return ok.Count;
        }
    }
}
