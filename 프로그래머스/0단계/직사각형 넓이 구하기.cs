using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.직사각형_넓이_구하기
{
    public class Solution
    {
        public int solution(int[,] dots)
        {
            int min_x = 256, max_x = -256;
            int min_y = 256, max_y = -256;

            for (int i = 0; i < dots.GetLength(0); i++)
            {
                if (dots[i, 0] < min_x)
                    min_x = dots[i, 0];

                if (dots[i, 0] > max_x)
                    max_x = dots[i, 0];

                if (dots[i, 1] < min_y)
                    min_y = dots[i, 1];

                if (dots[i, 1] > max_y)
                    max_y = dots[i, 1];

            }
            return Math.Abs(max_x - min_x) * Math.Abs(max_y - min_y);
        }
    }
}
