using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.순서_바꾸기
{
    public class Solution
    {
        public int[] solution(int[] num_list, int n)
        {
            List<int> list = new List<int>(num_list);

            var l1 = list.GetRange(n, list.Count - n);
            var l2 = list.GetRange(0, n);

            l1.AddRange(l2);

            return l1.ToArray();
        }
    }
}
