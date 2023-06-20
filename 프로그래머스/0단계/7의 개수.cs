using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스._7의_개수
{
    public class Solution
    {
        public int solution(int[] array)
        {
            int count = 0;
            for(int i=0; i<array.Length; i++)
            {
                int n = array[i];

                while(n > 0)
                {
                    if(n%10==7)
                    {
                        count++;
                    }
                    n /= 10;
                }
            }

            return count;
        }
    }
}
