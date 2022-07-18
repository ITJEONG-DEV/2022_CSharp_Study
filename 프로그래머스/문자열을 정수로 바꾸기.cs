using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열을_정수로_바꾸기
{
    class Solution
    {
        public int solution(string s)
        {
            bool sign = true;
            int n = 0;

            if (s[0] == '-')
                sign = false;
            else if (s[0] == '+')
                sign = true;
            else
                n = s[0] - '0';

            Console.WriteLine(n);
            for (int i = 1; i < s.Length; i++)
            {
                n *= 10;
                n += s[i] - '0';

                Console.WriteLine(n);
            }

            return sign ?n:-n;
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine(solution.solution("1324566"));
        }
    }
}
