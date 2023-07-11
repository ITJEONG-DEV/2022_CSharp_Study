using System;
using System.Text;

namespace 백준.Platinum.N_Queen
{
    // https://dl.acm.org/doi/pdf/10.1145/122319.122322
    public class Solution
    {
        static void main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());

            var solution = new Solution();

            solution.solution(n);
        }
        public void solution(int n)
        {
            bool odd = n % 2 == 1;

            if (odd) n--;

            StringBuilder str = new StringBuilder();

            if((!odd && n%6!=2) || (odd && n%6!=2))
            {
                for (int i = 1; i <= n / 2; i++)
                    str.AppendLine((i*2).ToString());

                for (int i = 1; i <= n / 2; i++)
                    str.AppendLine((2 * i - 1).ToString());
            }
            else if((!odd && n / 6 != 0) || (odd && n / 6 != 0))
            {
                for (int i = 1; i <= n/2; i++)
                    str.AppendLine((1 + (2 * (i - 1) + n / 2 - 1) % n).ToString());

                for (int i = n/2; i >=1; i--)
                    str.AppendLine((n - (2 * (i - 1) + n / 2 - 1) % n).ToString());
            }

            if (odd) str.AppendLine((n + 1).ToString());

            Console.Write(str.ToString());
        }
    }
}
