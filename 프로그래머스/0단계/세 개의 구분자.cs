using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.세_개의_구분자
{
    public class Solution
    {
        public string[] solution(string myStr)
        {
            myStr = myStr.Replace("a", " ");
            myStr = myStr.Replace("b", " ");
            myStr = myStr.Replace("c", " ");

            var result = myStr.Split(' ').Where(item => item.Length > 0).ToArray();

            if (result.Length == 0)
            {
                return new string[] { "EMPTY" };
            }

            return result;
        }
    }
}
