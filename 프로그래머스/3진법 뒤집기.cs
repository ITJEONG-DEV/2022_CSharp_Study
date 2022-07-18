using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스._3진법_뒤집기
{
    class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            long n_3 = 0;
            while(n>0)
            {
                n_3 = n_3 * 10 + n % 3;
                n /= 3;
            }

            int i = 0;
            while(n_3>0)
            {
                answer += (int)(n_3 % 10) * (int)Math.Pow(3, i++);
                n_3 /= 10;
            }

            return answer;
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine(solution.solution(100000000));
        }
    }
}
