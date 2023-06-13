using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.OX퀴즈
{
    public class Solution
    {
        public string[] solution(string[] quiz)
        {
            string[] result = new string[quiz.Length];

            for (int i = 0; i < quiz.Length; i++)
            {
                var words = quiz[i].Split(' ');

                int x = int.Parse(words[0]);
                int y = int.Parse(words[2]);
                int z = int.Parse(words[4]);

                switch (words[1])
                {
                    case "+":
                        if (x + y == z) result[i] = "O";
                        else result[i] = "X";
                        break;
                    case "-":
                        if (x - y == z) result[i] = "O";
                        else result[i] = "X";
                        break;
                }
            }

            return result;
        }
    }
}
