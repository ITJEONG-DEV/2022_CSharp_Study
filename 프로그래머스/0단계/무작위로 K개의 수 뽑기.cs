using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.무작위로_K개의_수_뽑기
{
    public class Solution
    {
        public int[] solution(int[] arr, int k)
        {
            List<int> arr_list = (new HashSet<int>(arr)).ToList();

            int[] answer = new int[k];
            for (int i = 0; i < k; i++)
            {
                if (i >= arr_list.Count)
                {
                    answer[i] = -1;
                }
                else
                {
                    answer[i] = arr_list[i];
                }
            }

            return answer;
        }
    }
}
