using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.접미사_배열
{
    public class Solution
    {
        public string[] solution(string my_string)
        {
            List<string> result = new List<string>();

            for(int i=0; i<my_string.Length; i++)
            {
                result.Add(my_string.Substring(i));
            }

            result.Sort();

            return result.ToArray();
        }
    }
}
