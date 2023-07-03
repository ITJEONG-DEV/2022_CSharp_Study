using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.큰_수_만들기
{
    public class Solution
    {
        public string solution(string number, int k)
        {
            StringBuilder str = new StringBuilder(number);

            int index = 0;
            int count = 0;

            char max = str[index];
            int max_index = 1;
            while(count < k && index < str.Length-2)
            {
                if (str[index] < str[index+1])
                {
                    str.Remove(index, 1);
                    count++;

                    if (str[index+1] > max)
                    {
                        max = str[index+1];
                        max_index = index + 1;
                    }
                    index = max_index-1;
                }
                else
                {
                    max = str[index];
                    max_index = index;

                    index++;
                }
            }

            if(count < k)
            {
                str.Remove(str.Length - 1, k-count);
            }

            return str.ToString();
        }
    }
}
