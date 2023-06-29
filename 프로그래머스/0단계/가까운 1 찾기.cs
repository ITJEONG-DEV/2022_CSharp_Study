using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.가까운_1_찾기
{
    public class Solution
    {
        public int solution(int[] arr, int idx)
        {
            for(int i=idx; i<arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
