using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.하노이의_탑
{
    public class Solution
    {
        public void Hanoi(int n, int start, int mid, int end, ref List<KeyValuePair<int, int>> list)
        {
            if (n == 1)
            {
                list.Add(new KeyValuePair<int, int>(start, end));
                return;
            }

            // start의 1 ~ n-1 을 mid로
            Hanoi(n - 1, start, end, mid, ref list);

            // start의 n 을 end로
            list.Add(new KeyValuePair<int, int>(start, end));

            // mid의 1 ~ n-1을 end번으로
            Hanoi(n - 1, mid, start, end, ref list);
        }
        public int[,] solution(int n)
        {
            List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();

            Hanoi(n, 1, 2, 3, ref list);

            int[,] result = new int[list.Count, 2];

            for (int i = 0; i < list.Count; i++)
            {
                result[i, 0] = list[i].Key;
                result[i, 1] = list[i].Value;
            }

            return result;
        }
    }
}
