using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.서울에서_김서방_찾기
{
    class Solution
    {
        public string solution(string[] seoul)
        {
            return "김서방은 " + seoul.ToList().IndexOf("Kim") + "에 있다";
        }
    }
}
