using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.숫자_찾기
{
    public class Solution
    {
        public int solution(int num, int k)
        {
            List<int> result = new List<int>();
            int index = 1;

            int n = num;
            while (n > 0)
            {
                if (n % 10 == k)
                {
                    result.Add(index);
                }

                index++;
                n /= 10;
            }

            if (result.Count == 0)
            {
                return -1;
            }

            return num.ToString().Length + 1 - result.Max();
        }
    }
}
