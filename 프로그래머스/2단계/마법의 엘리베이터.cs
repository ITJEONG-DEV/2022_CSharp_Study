using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.마법의_엘리베이터
{
    public class Solution
    {
        public int solution(int storey)
        {
            int count = 0;
            while (storey > 0)
            {
                int n = storey % 10;

                if (n == 5)
                {
                    if (storey / 10 % 10 >= 5)
                    {
                        count += 10 - n;
                        storey += (10 - n);
                    }
                    else
                    {
                        count += n;
                        storey -= n;
                    }
                }
                else if (n > 5)
                {
                    count += 10 - n;
                    storey += (10 - n);
                }
                else
                {
                    count += n;
                    storey -= n;
                }

                storey /= 10;
            }

            return count;
        }
    }
}
