using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.그림_확대
{
    public class Solution
    {
        public string[] solution(string[] picture, int k)
        {
            string[] answer = new string[picture.Length * k];

            for (int i = 0; i < picture.Length; i++)
            {
                StringBuilder strBuilder = new StringBuilder();
                for (int j = 0; j < picture[i].Length; j++)
                {

                    for (int m = 0; m < k; m++)
                    {
                        strBuilder.Append(picture[i][j]);
                    }
                }
                for (int m = 0; m < k; m++)
                {
                    answer[i * k + m] = strBuilder.ToString();
                }
            }

            return answer;
        }
    }
}
