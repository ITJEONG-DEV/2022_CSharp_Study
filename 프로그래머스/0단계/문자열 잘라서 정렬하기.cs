using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열_잘라서_정렬하기
{
    public class Solution
    {
        public string[] solution(string myString)
        {
            List<string> list = new List<string>(myString.Split('x'));

            list.Sort();

            while (list[0] == "")
            {
                list.RemoveAt(0);
            }

            return list.ToArray();
        }
    }
}
