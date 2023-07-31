using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 프로그래머스.배열에서_문자열_대소문자_변환하기
{
    public class Solution
    {
        public string[] solution(string[] strArr)
        {
            for(int i=0; i<strArr.Length; i++)
            {
                if(i%2==0) strArr[i] = strArr[i].ToLower();
                else strArr[i] = strArr[i].ToUpper();
            }
            return strArr;
        }
    }
}
