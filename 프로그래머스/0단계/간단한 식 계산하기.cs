using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.간단한_식_계산하기
{
    public class Solution
    {
        public int solution(string binomial)
        {
            var words = binomial.Split(' ');

            int a = int.Parse(words[0]);
            int b = int.Parse(words[2]);

            switch(words[1])
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
            }

            return -1;
        }
    }
}
