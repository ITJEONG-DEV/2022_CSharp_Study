using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스._2의_영역
{
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            List<int> list = new List<int>(arr);

            int first_index = list.IndexOf(2);
            int last_index = list.LastIndexOf(2);

            if (first_index == -1)
                return new int[] { -1 };

            else if (first_index == last_index) return new int[] { 2 };

            else return list.GetRange(first_index, last_index - first_index + 1).ToArray();
        }
    }
}
