using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 프로그래머스.k진수에서_소수_개수_구하기
{
    public class Solution
    {
        bool[] primNumbers;

        public string GetConvertingNumber(int n, int k)
        {
            StringBuilder str = new StringBuilder();

            while (n >0)
            {
                str.Insert(0, n % k);
                n /= k;
            }

            return str.ToString();
        }
        public bool IsPrimNumber(long n)
        {
            if (n == 1) return false;
            for(long i=2; i<=Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public int solution(int n, int k)
        {
            string s = k == 10 ? n.ToString() : GetConvertingNumber(n, k);

            var words = s.Split('0');

            Dictionary<long, bool> isPrimNumber = new Dictionary<long, bool>();

            int count = 0;
            foreach (var word in words)
            {
                if (word.Length == 0) continue;

                long num = long.Parse(word);
                if(!isPrimNumber.ContainsKey(num))
                    isPrimNumber[num] = IsPrimNumber(num);

                if (isPrimNumber[num])
                    count++;

                Console.WriteLine($"{num} : {isPrimNumber[num]}");
            }

            return count;
        }
    }
}
