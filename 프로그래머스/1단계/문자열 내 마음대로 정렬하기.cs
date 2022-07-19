using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열_내_마음대로_정렬하기
{
    class Solution
    {
        public string[] solution(string[] strings, int n)
        {
            return strings.OrderBy((x) => x).OrderBy((x) => x[n]).ToArray();
        }
    }
}
