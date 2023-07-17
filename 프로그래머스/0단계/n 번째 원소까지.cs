using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.n_번째_원소까지
{
    public class Solution
    {
        public int[] solution(int[] num_list, int n)
        {
            return num_list.ToList().GetRange(0, n).ToArray();
        }
    }
}
