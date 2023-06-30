using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.가장_가까운_같은_글자
{
    public class Solution
    {
        public int[] solution(string s)
        {
            int[] result = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (i == 0)
                {
                    result[i] = -1;
                }
                else
                {
                    bool flag = false;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (c == s[j])
                        {
                            result[i] = i - j;
                            flag = true;
                            break;
                        }
                    }

                    if(!flag)
                    {
                        result[i] = -1;
                    }
                }
            }

            return result;
        }
    }
}
