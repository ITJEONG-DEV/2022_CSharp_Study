using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.N개의_최소공배수
{
    public class Solution
    {
        public int GetGCD(int a, int b)
        {
            for(int i=b/2; i>1; i--)
            {
                if (a % i == 0 && b % i == 0)
                    return i;
            }

            return 1;
        }
        public int GetLCM(int a, int b)
        {
            if (a % b == 0) return a;

            int GCD = GetGCD(a, b);

            return a * b / GCD;
        }
        public int solution(int[] arr)
        {
            int n = arr[0];
            for(int i=1; i<arr.Length; i++)
            {
                int a = n > arr[i] ? n : arr[i];
                int b = n > arr[i] ? arr[i] : n;

                n = GetLCM(a, b);
            }

            return n;
        }
    }
}
