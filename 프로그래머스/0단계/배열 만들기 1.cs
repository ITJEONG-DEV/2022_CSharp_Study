using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.배열_만들기_1
{
    public class Solution
    {
        public int[] solution(int n, int k)
        {
            List<int> list = new List<int>();

            for (int i = k; i <= 10; i += k)
                list.Add(i);

            return list.ToArray();
        }
    }
}
