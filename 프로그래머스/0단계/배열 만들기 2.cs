using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.배열_만들기_2
{
    class Solution
    {
        public int[] solution(int l, int r)
        {
            int length = r.ToString().Length;

            List<int> arr = new List<int>();

            int totalLength = (int)Math.Pow(2, length);

            for (int i = 0; i < totalLength; i++)
            {
                int n = int.Parse(Convert.ToString(i, 2)) * 5;

                if (l <= n && n <= r)
                {
                    arr.Add(n);
                }
            }

            var result = arr.ToArray();

            if (result.Length == 0)
            {
                return new int[] { -1 };
            }
            else
            {
                Array.Sort(result);
                return result;
            }
        }
    }
}
