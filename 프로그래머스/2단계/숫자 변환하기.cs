using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.숫자_변환하기
{
    public class Solution
    {
        public int solution(int x, int y, int n)
        {
            if (x == y) return 0;

            Queue<KeyValuePair<int, int>> queue = new Queue<KeyValuePair<int, int>>();
            bool[] alreayOperated = new bool[y - x + 1];

            int count = 0;
            int v = y;

            while (v >= x)
            {
                for (int i = 0; i < 3; i++)
                {
                    int r;
                    if (i == 0) r = v - n;
                    else if (i == 1)
                    {
                        if (v % 2 != 0) continue;
                        r = v / 2;
                    }
                    else
                    {
                        if (v % 3 != 0) continue;
                        r = v / 3;
                    }

                    if (r == x) return count + 1;
                    if (r < x) continue;

                    if (!alreayOperated[y - r])
                    {
                        alreayOperated[y - r] = true;
                        queue.Enqueue(new KeyValuePair<int, int>(r, count + 1));
                    }
                }

                if (queue.Count == 0) return -1;

                var item = queue.Dequeue();
                v = item.Key;
                count = item.Value;
            }

            return -1;
        }
    }
}
