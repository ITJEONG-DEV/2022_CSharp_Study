using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.유사_칸토어_비트열
{
    public class Solution
    {
        public string Get5String(long n)
        {
            if (n == 0) return "0";

            StringBuilder str = new StringBuilder();

            while (n > 0)
            {
                str.Insert(0, n % 5);
                n /= 5;
            }

            return str.ToString();
        }

        public int solution(int n, long l, long r)
        {
            string start = Get5String(l - 1);
            string end = Get5String(r - 1);

            if (l == r)
            {
                if (start.Contains('2')) return 0;
                else return 1;
            }

            int max_length = end.Length;
            int length_gap = end.Length - start.Length;

            int index = 0;

            int count = 0;
            bool s2 = false;
            bool e2 = false;
            while (index < max_length)
            {
                int s, e;
                if (length_gap > index)
                {
                    s = 0;
                }
                else
                {
                    s = start[index - length_gap] - '0';
                }
                e = end[index] - '0';

                int term = (int)Math.Pow(4, max_length - index - 1);

                if (index == 0)
                {
                    for (int i = s; i <= e; i++)
                    {
                        if (i != 2)
                        {
                            count += term;
                        }
                    }
                }
                else
                {
                    if (!s2)
                    {
                        for (int i = 0; i < s; i++)
                        {
                            if (i != 2)
                                count -= term;
                        }
                    }

                    if (!e2)
                    {
                        for (int i = e + 1; i < 5; i++)
                        {
                            if (i != 2)
                                count -= term;
                        }
                    }
                }

                index++;

                if (e == 2) e2 = true;
                if (s == 2) s2 = true;
            }

            return count;
        }
    }
}
