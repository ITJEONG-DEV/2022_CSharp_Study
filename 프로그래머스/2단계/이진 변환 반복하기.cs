using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.이진_변환_반복하기
{
    public class Solution
    {
        public int[] solution(string s)
        {
            List<int> result = new List<int>();
            int repeat_count = 0;
            int zero_count = 0;
            while (s.Length > 1)
            {
                int str_count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '1')
                    {
                        str_count++;
                    }
                    else
                    {
                        zero_count++;
                    }
                }

                s = Convert.ToString(str_count, 2);
                repeat_count++;
            }

            return new int[2] { repeat_count, zero_count };
        }
    }
}
