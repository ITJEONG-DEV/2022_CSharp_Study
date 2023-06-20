using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.소인수분해
{
    public class Solution
    {
        public int[] solution(int n)
        {
            List<int> result = new List<int>();

            while (n > 1)
            {
                bool change = false;

                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        if (result.IndexOf(i) == -1)
                        {
                            result.Add(i);
                        }
                        n /= i;
                        change = true;
                        break;
                    }
                }

                if (!change)
                {
                    if (result.IndexOf(n) == -1)
                    {
                        result.Add(n);
                    }
                    n /= n;
                    break;
                }
            }

            return result.ToArray();
        }
    }
}
