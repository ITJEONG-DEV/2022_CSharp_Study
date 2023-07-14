using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.첫_번째로_나오는_음수
{
    public class Solution
    {
        public int solution(int[] num_list)
        {
            for(int i=0; i<num_list.Length; i++)
                if (num_list[i] < 0) return i;

            return -1;
        }
    }
}
