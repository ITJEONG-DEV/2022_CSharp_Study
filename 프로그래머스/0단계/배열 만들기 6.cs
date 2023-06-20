using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.배열_만들기_6
{
    public class Solution
    {
        public int[] solution(int[] arr)
        {

            List<int> stk = new List<int>();
            int i = 0;

            while (i < arr.Length)
            {
                if (stk.Count == 0)
                {
                    stk.Add(arr[i]);
                    i++;
                }
                else
                {
                    if (stk[stk.Count - 1] == arr[i])
                    {
                        stk.RemoveAt(stk.Count - 1);
                        i++;
                    }
                    else
                    {
                        stk.Add(arr[i]);
                        i++;
                    }
                }
            }

            if (stk.Count == 0)
            {
                return new int[] { -1 };
            }

            return stk.ToArray();
        }
    }
}
