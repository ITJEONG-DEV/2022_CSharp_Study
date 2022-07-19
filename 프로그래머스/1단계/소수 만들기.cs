using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.소수_만들기
{
    class Solution
    {
        public bool CheckPrimNumber(int a, int b, int c)
        {
            int n = a + b + c;

            for (int i = 2; i < n / 2; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
        public int solution(int[] nums)
        {
            int answer = 0;

            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    for (int k = j + 1; k < nums.Length; k++)
                        if (CheckPrimNumber(nums[i], nums[j], nums[k]))
                            answer++;

            return answer;
        }
    }
}
