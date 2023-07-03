using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.푸드_파이트_대회
{
    public class Solution
    {
        public string solution(int[] food)
        {
            StringBuilder stringBuilder= new StringBuilder();

            for(int i=1; i<food.Length; i++)
            {
                int n = food[i] / 2;
                stringBuilder.Append((char)(i+'0'), n);
            }

            string s1 = stringBuilder.ToString();
            string s2 = String.Join("", s1.Reverse());

            return s1 + "0" + s2;
        }
    }
}
