using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열_정렬하기_2
{
    public class Solution
    {
        public string solution(string my_string)
        {
            List<char> list = new List<char>();

            foreach(char c in my_string)
            {
                char t = c;
                if(c>='A' && c<='Z')
                {
                    t = (char)(c - 'A' + 'a'); 
                }

                list.Add(t);
            }

            list.Sort();

            return String.Join("", list);
        }
    }
}
