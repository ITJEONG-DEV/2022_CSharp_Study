using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.평행
{
    public class Solution
    {
        public float getInclination(int x1, int y1, int x2, int y2)
        {
            return (float)(x1 - x2) / (y1 - y2);
        }
        public int isParallel(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            var a1 = getInclination(x1, y1, x2, y2);
            var a2 = getInclination(x3, y3, x4, y4);

            if (a1 == a2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int solution(int[,] dots)
        {
            int[,] list = { { 0, 1, 2, 3 }, { 0, 2, 1, 3 }, { 0, 3, 1, 2 } };

            int result = 0;
            for (int i = 0; i < list.GetLength(0); i++)
            {
                result |= isParallel(
                    dots[list[i, 0], 0], dots[list[i, 0], 1],
                    dots[list[i, 1], 0], dots[list[i, 1], 1],
                    dots[list[i, 2], 0], dots[list[i, 2], 1],
                    dots[list[i, 3], 0], dots[list[i, 3], 1]
                );
            }

            return result;
        }
    }
}
