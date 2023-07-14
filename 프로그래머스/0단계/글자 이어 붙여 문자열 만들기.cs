using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.글자_이어_붙여_문자열_만들기
{
    public class Solution
    {
        public string solution(string my_string, int[] index_list)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < index_list.Length; i++)
                str.Append(my_string[index_list[i]]);

            return str.ToString();
        }
    }
}
