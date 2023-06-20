using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열_묶기
{
    public class Solution
    {
        public int solution(string[] strArr)
        {
            var dict = new Dictionary<int, int>();

            foreach(string str in strArr)
            {
                if (!dict.ContainsKey(str.Length))
                {
                    dict[str.Length] = 0;
                }

                dict[str.Length]++;
            }

            return dict.Values.Max();
        }
    }
}
