using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.연속된_부분_수열의_합
{
    public class Solution
    {
        public int[] solution(int[] sequence, int k)
        {

            Queue<int> queue = new Queue<int>();
            int sum = 0;
            int start = 0;
            int end = 0;

            List<KeyValuePair<int, int>> result_candidate = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
                end = i;

                while (sum > k)
                {
                    sum -= sequence[start];
                    start++;
                }

                if (sum == k)
                {
                    result_candidate.Add(new KeyValuePair<int, int>(start, end));
                }
            }

            int[] result = new int[2] { -1, 1000001 };
            for (int i = 0; i < result_candidate.Count; i++)
            {
                if (result[1] - result[0] > result_candidate[i].Value - result_candidate[i].Key)
                {
                    result[0] = result_candidate[i].Key;
                    result[1] = result_candidate[i].Value;
                }
            }

            return result;
        }
    }
}
