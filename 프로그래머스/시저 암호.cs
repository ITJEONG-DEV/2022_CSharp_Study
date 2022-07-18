using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.시저_암호
{
    class Solution
    {
        public string solution(string s, int n)
        {
            string answer = "";
            for(int i = 0; i <s.Length; i++)
            {
                if (s[i] == ' ')
                    answer += ' ';

                else if (s[i] <= 'Z' && s[i] + n > 'Z')
                    answer += (char)(s[i] + n - 26);

                else if (s[i] <= 'z' && s[i] + n > 'z')
                    answer += (char)(s[i] + n - 26);

                else
                    answer += (char)(s[i] + n);
            }

            return answer;
        }
    }
}
