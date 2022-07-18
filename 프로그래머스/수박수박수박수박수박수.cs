using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.수박수박수박수박수박수
{
    class Solution
    {
        public string solution(int n)
        {
            string answer = "";
            while(n>0)
            {
                if(n>1)
                {
                    n -= 2;
                    answer += "수박";
                }
                else if(n==1)
                {
                    answer += "수";
                    break;
                }
            }

            return answer;
        }
    }
}
