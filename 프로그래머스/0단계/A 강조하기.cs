using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.A_강조하기
{
    public class Solution
    {
        public string solution(string myString)
        {
            return myString.ToLower().Replace("a", "A");
        }
    }
}
