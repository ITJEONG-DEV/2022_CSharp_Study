using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.명예의_전당_1
{
    public class Solution
    {
        private int[] arr;

        public void Insert(int n, int k)
        {
            for (int i = 0; i <= k; i++)
            {
                int m = arr[i];
                if (n > m)
                {
                    arr[i] = n;
                    n = m;
                }
            }
        }
        public int[] solution(int k, int[] score)
        {
            List<int> result = new List<int>();
            arr = new int[k];

            for (int i = 0; i < score.Length; i++)
            {
                int n = score[i];
                if (i < k)
                {
                    Insert(n, i);
                    result.Add(arr[i]);
                }
                else
                {
                    Insert(n, k - 1);
                    result.Add(arr[k - 1]);
                }
            }

            return result.ToArray();
        }
    }
}
