using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.카운트_다운
{
    public class Solution
    {
        public int[] solution(int start, int end)
        {
            List<int> list = new List<int>();

            for(int i=start; i>=end; i--)
                list.Add(i);

            return list.ToArray();
        }
    }
}
