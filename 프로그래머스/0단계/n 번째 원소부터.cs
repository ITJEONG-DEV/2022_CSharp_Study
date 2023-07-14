using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.n_번째_원소부터
{
    public class Solution
    {
        public int[] solution(int[] num_list, int n)
        {
            List<int> list = new List<int>();

            for(int i=n; i<num_list.Length; i++)
                list.Add(i);

            return list.ToArray();
        }
    }
}
