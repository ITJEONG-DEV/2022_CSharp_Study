using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 프로그래머스.주사위_게임_3;

namespace 프로그래머스.구슬을_나누는_경우의_수
{
    public class Solution
    {
        public int solution(int balls, int share)
        {
            if (share == balls) return 1;

            List<int> denom = new List<int>();
            List<int> numer = new List<int>();

            // denom
            for (int i = 2; i <= balls - share; i++)
            {
                denom.Add(i);
            }
            for (int i = 2; i <= share; i++)
            {
                denom.Add(i);
            }

            // numer
            for (int i = 2; i <= balls; i++)
            {
                int index = denom.IndexOf(i);

                if(index != -1)
                {
                    denom.RemoveAt(index);
                }
                else
                {
                    numer.Add(i);
                }
            }

            int result = 1;

            for(int i=0; i<numer.Count; i++)
            {
                result *= numer[i];

                while(denom.Count > 0)
                {
                    var min = denom.Min();
                    var index = denom.IndexOf(min);
                    if(result % min != 0)
                        break;

                    result /= min;
                    denom.RemoveAt(index);
                }
            }

            return result;
        }
    }
}
