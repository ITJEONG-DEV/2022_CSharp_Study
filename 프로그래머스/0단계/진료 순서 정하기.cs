using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.진료_순서_정하기
{
    public class Solution
    {
        public int[] solution(int[] emergency)
        {
            List<int> list = new List<int>(emergency);
            List<int> list2 = new List<int>(emergency);

            int[] result = new int[list.Count];

            while(list.Count > 0)
            {
                int max = list.Max();
                int index = list2.IndexOf(max);
                list.Remove(max);
                result[index] = list2.Count - list.Count;
            }

            return result;
        }
    }
}
