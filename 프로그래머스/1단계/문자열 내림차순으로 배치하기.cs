using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열_내림차순으로_배치하기
{
    class Solution
    {
        public string solution(string s)
        {
            return new string(s.ToArray().OrderBy(x => x).Reverse().ToArray());
        }
    }
}
