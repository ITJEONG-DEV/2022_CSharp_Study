using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.콜라_문제
{
    public class Solution
    {
        public int solution(int a, int b, int n)
        {
            int count = 0;

            int bottle = n;
            while (bottle >= a)
            {
                int giving = bottle / a;
                int get = giving * b;

                count += get;

                bottle = bottle % a + get;
            }

            return count;
        }
    }
}
