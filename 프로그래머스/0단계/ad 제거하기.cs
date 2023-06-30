using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.ad_제거하기
{
    public class Solution
    {
        public string[] solution(string[] strArr)
        {
            List<string> result = new List<string>();
            foreach (string str in strArr)
            {
                if(! str.Contains("ad"))
                {
                    result.Add(str);
                }
            }


            return result.ToArray();
        }
    }
}
