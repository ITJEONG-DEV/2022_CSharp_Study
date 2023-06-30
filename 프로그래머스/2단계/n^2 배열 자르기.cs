using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.n_2_배열_자르기
{
    public class Solution
    {
        public int[] solution(int n, long left, long right)
        {
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    arr[i, j] = i+1;

            int[] result = new int[right - left + 1];
            for (long i = left; i<=right; i++)
            {
                int y = (int)((i + 1) / n);
                int x = (int)((i + 1) % n);

                result[i - left] = y > x ? y : x;
            }

            return result;
        }
    }
}
