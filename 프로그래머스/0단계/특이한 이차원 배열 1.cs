using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.특이한_이차원_배열_1
{
    public class Solution
    {
        public int[,] solution(int n)
        {
            int[,] answer = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                answer[i, i] = 1;
            }
            return answer;
        }
    }
}
