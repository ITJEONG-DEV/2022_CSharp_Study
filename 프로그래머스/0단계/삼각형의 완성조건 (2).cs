using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.삼각형의_완성조건_2
{
    public class Solution
    {
        public int solution(int[] sides)
        {
            // max == a
            int count = 1;

            int max = sides.Max();
            int min = sides.Min();

            // max가 가장 긴 변
            if( max - min  < max)
            {
                count += max - (max - min) - 1;
            }
            // a가 가장 긴 변
            if( max < max + min)
            {
                count += max + min - max - 1;
            }

            return count;
        }
    }
}
