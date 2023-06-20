using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.프로그래머스._0단계
{
    public class Solution
    {
        public int[] solution(int[,] score)
        {
            List<int> sum = new List<int>();

            for (int i = 0; i < score.GetLength(0); i++)
            {
                sum.Add(score[i, 0] + score[i, 1]);
            }

            int[] answer = new int[score.GetLength(0)];

            int rank = 1;
            int max = sum.Max();
            while (max != -1)
            {
                int index = sum.IndexOf(max);
                int duplication_count = 0;
                while (index != -1)
                {
                    duplication_count++;
                    answer[index] = rank;
                    sum[index] = -1;
                    index = sum.IndexOf(max);
                }
                rank += duplication_count;

                max = sum.Max();
            }

            return answer;
        }
    }
}
