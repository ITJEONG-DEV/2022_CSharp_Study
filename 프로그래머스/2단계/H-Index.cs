using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.H_Index
{
    public class Solution
    {
        public int solution(int[] citations)
        {
            List<int> citiations_list = new List<int>(citations);

            citiations_list.Sort();

            if (citiations_list[0] > citiations_list.Count)
            {
                return citiations_list.Count;
            }

            int index = citiations_list.Count - 1;
            for (int h = citiations_list[citiations_list.Count - 1]; h >= 0; h--)
            {
                for (int i = index - 1; i >= 0; i--)
                {
                    if (citiations_list[i] < h)
                    {
                        int h_paper = citiations_list.Count - (i + 1);
                        int citiations_of_current = citiations_list[i];

                        if (h_paper >= h && citiations_of_current <= h)
                        {
                            return h;
                        }

                        break;
                    }
                }
            }

            return 0;
        }
    }
}
