using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.배열의_길이를_2의_거듭제곱으로_만들기
{
    public class Solution
    {
        public int getRelateNumber(int n)
        {
            int a = 1;
            while(a < n)
            {
                a *= 2;
            }

            return a;
        }
        public int[] solution(int[] arr)
        {
            int n = getRelateNumber(arr.Length);

            if(n==arr.Length)
            {
                return arr;
            } else
            {
                List<int> result = new List<int>(arr);

                for(int i=arr.Count(); i<n; i++)
                {
                    result.Add(0);
                }

                return result.ToArray();
            }
        }
    }
}
