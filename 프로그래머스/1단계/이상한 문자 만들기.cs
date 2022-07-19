using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.이상한_문자_만들기
{
    class Solution
    {
        public string solution(string s)
        {
            string answer = "";
            int wordIndex = 0;
            for(int i=0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    answer += ' ';
                    wordIndex = 0;
                    continue;
                }

                if (wordIndex % 2 == 0)
                {
                    answer += s[i].ToString().ToUpper();
                    wordIndex++;
                }
                else
                {
                    answer += s[i].ToString().ToLower();
                    wordIndex++;
                }
            }

            return answer;
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();

            Console.Write(solution.solution("try hello world!!"));
        }
    }
}
