using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.조건에_맞게_수열_변환하기_1
{
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] >= 50 && arr[i] % 2 == 0)
                    arr[i] /= 2;

                else if (arr[i] < 50 && arr[i] % 2 == 1)
                    arr[i] *= 2;
            }

            return arr;
        }
    }
}
