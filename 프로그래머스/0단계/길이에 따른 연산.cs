using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.길이에_따른_연산
{
    public class Solution
    {
        public int solution(int[] num_list)
        {
            if(num_list.Length >= 10)
            {
                int sum = 0;
                for (int i = 0; i < num_list.Length; i++)
                    sum += num_list[i];

                return sum;
            }
            else
            {
                int mul = 1;
                for (int i = 0; i < num_list.Length; i++)
                    mul *= num_list[i];

                return mul;
            }
        }
    }
}
