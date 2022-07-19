using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.가운데_글자_가져오기
{
    class Solution
    {
        public string solution(string s)
        {
            if (s.Length % 2 == 1)
                return s.Substring(s.Length / 2, 1);
            else
                return s.Substring(s.Length / 2 -1, 2);
        }
    }
}
