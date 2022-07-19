using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.핸드폰_번호_가리기
{
    class Solution
    {
        public string solution(string phone_number)
        {
            string answer = "";
            for (int i = 0; i < phone_number.Length - 4; i++)
                answer += "*";

            return answer + phone_number.Substring(phone_number.Length - 4);
        }
    }
}
