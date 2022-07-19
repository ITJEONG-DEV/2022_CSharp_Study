using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.소수_찾기
{
    class Solution
    {
        public int solution(int n)
        {
            int count = 0;
            List<int> primList = new List<int>();
            for(int i = 2; i <=n; i++)
            {
                bool flag = true;

                foreach(int prim in primList)
                {
                    if (prim > Math.Sqrt(i))
                        break;

                    if (i % prim == 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    primList.Add(i);
                    count++;
                }
            }

            return count;
        }
    }
}
