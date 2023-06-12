using System;
using System.Collections.Generic;

namespace 프로그래머스.콜라츠_수열_만들기
{
    public class Solution
    {
        public int[] solution(int n)
        {
            List<int> arr = new List<int>();
            arr.Add(n);

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    arr.Add(n);
                }
                else
                {
                    n = 3 * n + 1;
                    arr.Add(n);
                }
            }

            return arr.ToArray();
        }
    }
}
