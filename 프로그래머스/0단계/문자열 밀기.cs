using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열_밀기
{
    public class Solution
    {
        public string push(string s)
        {
            return s[s.Length - 1] + s.Substring(0, s.Length - 1);
        }
        public int solution(string A, string B)
        {
            int count = A.Length;

            string target = A;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(target);
                if (target == B)
                {
                    return i;
                }

                target = push(target);
            }

            return -1;
        }
    }
}
