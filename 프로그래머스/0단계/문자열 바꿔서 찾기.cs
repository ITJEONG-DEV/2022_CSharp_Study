using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열_바꿔서_찾기
{
    public class Solution
    {
        public int solution(string myString, string pat)
        {
            string newString = "";
            for(int i=0; i<myString.Length; i++)
            {
                if (myString[i] == 'A')
                    newString += "B";
                else if (myString[i] == 'B')
                    newString += "A";
                else
                    newString += myString[i];
            }

            if (newString.Contains(pat))
                return 1;
            else return 0;
        }
    }
}
