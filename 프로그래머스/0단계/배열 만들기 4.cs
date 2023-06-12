using System;
using System.Collections.Generic;

namespace ConsoleApp1.프로그래머스.배열_만들기_4
{
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            int i = 0;

            List<int> stk = new List<int>();

            while (i < arr.Length)
            {
                if (stk.Count == 0)
                {
                    stk.Add(arr[i]);
                    i++;
                }
                else if (stk[stk.Count - 1] < arr[i])
                {
                    stk.Add(arr[i]);
                    i++;
                }
                else
                {
                    stk.RemoveAt(stk.Count - 1);
                }
            }

            return stk.ToArray();
        }
    }
}
