using System;
using System.Collections.Generic;
using System.Linq;

namespace 프로그래머스.전국_대회_선발_고사
{
    public class Solution
    {
        public int solution(int[] rank, bool[] attendance)
        {
            List<int> selection = new List<int>();

            for (int i = 0; i < attendance.Length; i++)
            {
                if (attendance[i])
                {
                    selection.Add(rank[i]);
                }
            }

            int a = selection.Min();
            selection.Remove(a);
            a = Array.IndexOf(rank, a);

            int b = selection.Min();
            selection.Remove(b);
            b = Array.IndexOf(rank, b);

            int c = selection.Min();
            c = Array.IndexOf(rank, c);

            return 10000 * (a) + 100 * (b) + (c);
        }
    }
}
