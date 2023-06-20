using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.qr_code
{
    public class Solution
    {
        public string solution(int q, int r, string code)
        {
            StringBuilder str = new StringBuilder();
            for(int i=0; i<code.Length; i++)
            {
                if(i%q == r)
                {
                    str.Append(code[i]);
                }
            }
            return str.ToString();
        }
    }
}
