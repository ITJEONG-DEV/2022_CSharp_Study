using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.원하는_문자열_찾기
{
    public class Solution
    {
        public int solution(string myString, string pat)
        {
            return myString.ToUpper().Contains(pat.ToUpper()) ? 1 : 0;
        }
    }
}
