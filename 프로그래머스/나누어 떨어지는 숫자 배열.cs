using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.나누어_떨어지는_숫자_배열
{
    class Solution
    {
        public int[] solution(int[] arr, int divisor)
        {
            List<int> list = new List<int>();
            foreach(int n in arr)
            {
                if (n % divisor == 0)
                    list.Add(n);
            }

            if (list.Count == 0)
                return new int[] { -1 };

            return list.OrderBy(x=>x).ToArray();
        }
    }
}
