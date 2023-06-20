using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.컨트롤_제트
{
    public class Solution
    {
        public int solution(string s)
        {
            int sum = 0;
            int n = 0;
            foreach(var item in s.Split(' '))
            {
                if(item == "Z")
                {
                    sum -= n;
                }
                else
                {
                    sum += n;
                    n = int.Parse(item);
                }
            }
            sum += n;

            return sum;
        }
    }
}
