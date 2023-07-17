using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.n개_간격의_원소들
{
    public class Solution
    {
        public int[] solution(int[] num_list, int n)
        {
            List<int> list = new List<int>();

            for(int i=0; i<num_list.Length; i+=n)
            {
                list.Add(num_list[i]);
            }

            return list.ToArray();
        }
    }
}
