using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.최소_직사각형
{
    class Solution
    {
        public int solution(int[,] sizes)
        {
            for (int i = 0; i < sizes.Length / 2; i++)
                if (sizes[i, 0] < sizes[i, 1])
                {
                    sizes[i, 0] ^= sizes[i, 1];
                    sizes[i, 1] ^= sizes[i, 0];
                    sizes[i, 0] ^= sizes[i, 1];
                }

            int w = 0, h = 0;
            for (int i = 0; i < sizes.Length / 2; i++)
            {
                if (sizes[i, 0] > w)
                    w = sizes[i, 0];
                if (sizes[i, 1] > h)
                    h = sizes[i, 1];
            }

            return w*h;
        }

        public static void main(string[] args)
        {
            int[,] sizes = { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(sizes));
        }

    }
}
