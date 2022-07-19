using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.제일_작은_수_제거하기
{
    class Solution
    {
        public int[] solution(int[] arr)
        {
            var list = arr.ToList();
            list.Remove(list.Min());

            if (list.Count == 0)
                return new int[1] { -1 };
            else
                return list.ToArray();
        }
    }
}
