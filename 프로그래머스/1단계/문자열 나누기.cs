using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열_나누기
{
    public class Solution
    {
        public int solution(string s)
        {
            int result = 0;

            string target = s;
            char x = target[0];

            int count_x = 1;
            int count_o = 0;

            int index = 1;
            while (target.Length>0)
            {
                if (target[index] == x)
                {
                    count_x++;
                }
                else
                {
                    count_o++;
                }

                index++;

                if(count_x == count_o)
                {
                    target = target.Substring(index);
                    result++;

                    if (target.Length == 0)
                    {
                        break;
                    }

                    index = 1;
                    count_x = 1;
                    count_o = 0;
                }
            }

            return result;
        }
    }
}
