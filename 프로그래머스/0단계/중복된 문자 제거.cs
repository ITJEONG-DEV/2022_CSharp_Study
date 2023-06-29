using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.중복된_문자_제거
{
    public class Solution
    {
        public string solution(string my_string)
        {
            List<char> result = new List<char>();
            foreach(char item in my_string)
            {
                if(!result.Contains(item))
                {
                    result.Add(item);
                }
            }

            return String.Join("", result);
        }
    }
}
