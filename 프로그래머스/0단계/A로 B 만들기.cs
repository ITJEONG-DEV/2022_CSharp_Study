using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.A로_B_만들기
{
    public class Solution
    {
        public int solution(string before, string after)
        {
            while (before.Length > 0)
            {
                if(before.Count(f => (f == before[0])) == after.Count(f => (f == before[0])))
                {
                    after = after.Replace(before[0].ToString(), "");
                    before = before.Replace(before[0].ToString(), "");
                }
                else
                {
                    return 0;
                }
            }

            if(after.Length == 0)
            {
                return 1;
            }

            return 0;
        }
    }
}
