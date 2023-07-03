using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.최솟값_만들기
{
    public class Solution
    {
        public int solution(int[] A, int[] B)
        {
            List<int> a = new List<int>(A);
            a.Sort();

            List<int> b = new List<int>(B);
            b.Sort();

            int sum = 0;
            int length = A.Length;
            for(int i=0; i<length; i++)
            {
                sum += a[i] * b[length - i];
            }

            return sum;
        }
    }
}
