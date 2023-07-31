using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.공백으로_구분하기_2
{
    public class Solution
    {
        public string[] solution(string my_string)
        {
            List<string> list = new List<string>(my_string.Trim().Split());

            while(list.IndexOf("") != -1)
            {
                list.RemoveAt(list.IndexOf(""));
            }

            return list.ToArray();
        }
    }
}
