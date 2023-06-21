using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자_개수_세기
{
    public class Solution
    {
        public int[] solution(string my_string)
        {
            int[] answer = new int[52];

            foreach(char c in my_string)
            {
                if(c <= 'Z')
                {
                    answer[c - 'A']++;
                }
                else
                {
                    answer[c - 'a' + 26]++;
                }
            }

            return answer;
        }
    }
}
