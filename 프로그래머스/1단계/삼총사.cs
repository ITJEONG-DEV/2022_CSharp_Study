using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.삼총사
{
    public class Solution
    {
        public int solution(int[] number)
        {
            int count = 0;
            for(int i=0; i<number.Length; i++)
                for(int j=i+1; j<number.Length; j++)
                    for(int k=j+1; k<number.Length; k++)
                        if (number[i] + number[j] + number[k] == 0)
                            count++;
            return count;
        }
    }
}
