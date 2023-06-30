using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.x_사이의_개수
{
    public class Solution
    {
        public int[] solution(string myString)
        {
            List<int> result = new List<int>();
            string[] words = myString.Split('x');

            foreach(string word in words)
            {
                result.Add(word.Length);
            }

            return result.ToArray();
        }
    }
}
