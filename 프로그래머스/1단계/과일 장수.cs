using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.과일_장수
{
    public class Solution
    {
        public int solution(int k, int m, int[] score)
        {
            List<int> list = new List<int>(score);
            list.Sort();
            list.Reverse();

            int result = 0;
            for (int box = 1; box * m <= list.Count; box++)
            {
                result += list[box * m - 1] * m;
            }

            return result;
        }
    }
}
