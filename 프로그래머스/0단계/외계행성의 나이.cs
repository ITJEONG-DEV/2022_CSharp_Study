using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.외계행성의_나이
{
    public class Solution
    {
        public string solution(int age)
        {
            List<char> chars= new List<char>();

            while(age > 0)
            {
                int n = age % 10;
                chars.Add((char)(n + 'a'));
                age /= 10;
            }

            chars.Reverse();

            return String.Join("", chars);
        }
    }
}
