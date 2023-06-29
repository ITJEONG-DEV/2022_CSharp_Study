using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.배열_만들기_5
{
    public class Solution
    {
        public int[] solution(string[] intStrs, int k, int s, int l)
        {
            List<int> result = new List<int>();

            foreach(string intStr in intStrs)
            {
                int n = int.Parse(intStr.Substring(s, l));

                if (n > k)
                {
                    result.Add(n);
                }
            }

            return result.ToArray();
        }
    }
}
