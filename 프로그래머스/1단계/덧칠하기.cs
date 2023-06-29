using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.덧칠하기
{
    public class Solution
    {
        public int solution(int n, int m, int[] section)
        {
            List<int> list = new List<int>();

            int count = 0;

            int lpointer, rpointer;

            while(list.Count > 0)
            {
                int min = list.Min();
                lpointer = min + m - 1;
                count++;

                while (list.Count > 0)
                {
                    if (list[0] <= lpointer)
                    {
                        list.RemoveAt(0);
                    }
                    else
                    {
                        break;
                    }
                }

                if (list.Count > 0)
                {
                    int max = list.Max();
                    rpointer = max - m - 1;
                    count++;

                    while (list.Count > 0)
                    {
                        if (list[list.Count-1] >= rpointer)
                        {
                            list.RemoveAt(list.Count - 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return count;
        }
    }
}
