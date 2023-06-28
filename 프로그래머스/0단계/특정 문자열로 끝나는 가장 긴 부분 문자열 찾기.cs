using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.특정_문자열로_끝나는_가장_긴_부분_문자열_찾기
{
    public class Solution
    {
        public string solution(string myString, string pat)
        {
            while(true)
            {
                int index = myString.LastIndexOf(pat[pat.Length - 1]);


                string substring = myString.Substring(0, index + 1);

                if (substring.Contains(pat)) {
                    return substring;
                }

                myString = substring;
            }
        }
    }
}
