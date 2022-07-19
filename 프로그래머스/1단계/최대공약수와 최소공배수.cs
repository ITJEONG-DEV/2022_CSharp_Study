using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.최대공약수와_최소공배수
{
    class Solution
    {
        int[] FindDivisor(int n)
        {
            HashSet<int> arr = new HashSet<int>();
            for(int i=1; i<=n; i++)
                if(n%i==0)
                    arr.Add(i);

            return arr.ToArray();
        }
        int FindGreatestCommonDivisor(int n, int m)
        {
            var nDivisor = FindDivisor(n).OrderBy((x)=>x).Reverse().ToArray();
            var mDivisor = FindDivisor(m).OrderBy((x) => x).Reverse().ToArray();

            int nIndex = 0, mIndex = 0;

            while(nIndex < nDivisor.Length && mIndex < mDivisor.Length)
            {
                if (nDivisor[nIndex] == mDivisor[mIndex])
                    return nDivisor[nIndex];
                else if (nDivisor[nIndex] > mDivisor[mIndex])
                    nIndex++;
                else
                    mIndex++;
            }

            return 1;
        }
        int FindLeastCommonMultiple(int n, int m, int gcf)
        {
            return n * m / gcf;

        }
        public int[] solution(int n, int m)
        {
            int gcf = FindGreatestCommonDivisor(n, m);
            int lcm = FindLeastCommonMultiple(n, m, gcf);

            return new int[] { gcf, lcm };
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();

            var result = solution.solution(3, 12);
            Console.WriteLine(result[0]+" " + result[1]);
        }
    }
}
