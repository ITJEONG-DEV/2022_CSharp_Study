using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.로또의_최고_순위와_최저_순위
{
    class Solution
    {
        public class SolutionClass
        {
            public int[] solution(int[] lottos, int[] win_nums)
            {
                int min = 0;
                int zero = 0;
                for (int i = 0; i < lottos.Length; i++)
                    if (lottos[i] == 0)
                        zero++;
                    else if (win_nums.Contains(lottos[i]))
                        min++;


                return new int[] { 7 - (min + zero) >= 6 ? 6 : 7 - (min+zero), 7 - min >= 6 ? 6 : 7 - min };
            }
        }
    }
}
