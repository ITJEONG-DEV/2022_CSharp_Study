using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.성격_유형_검사하기
{
    public class Solution
    {
        public string solution(string[] survey, int[] choices)
        {
            Dictionary<char, int> score = new Dictionary<char, int>();

            score['R'] = 0;
            score['T'] = 0;
            score['C'] = 0;
            score['F'] = 0;
            score['J'] = 0;
            score['M'] = 0;
            score['A'] = 0;
            score['N'] = 0;

            for (int i=0; i< choices.Length; i++)
            {
                string item = survey[i];

                switch(choices[i])
                {
                    case 1:
                    case 2:
                    case 3:
                        score[item[0]] += 4 - choices[i];
                        break;
                    case 4:
                        break;
                    case 5:
                    case 6:
                    case 7:
                        score[item[1]] += choices[i] - 4;
                        break;
                }
            }

            var r1 = (score['R'] >= score['T'] ? 'R' : 'T');
            var r2 = (score['C'] >= score['F'] ? 'C' : 'F');
            var r3 = (score['J'] >= score['M'] ? 'J' : 'M');
            var r4 = (score['A'] >= score['N'] ? 'A' : 'N');

            return $"{r1}{r2}{r3}{r4}";
        }
    }
}
