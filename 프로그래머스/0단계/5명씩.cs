using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스._5명씩
{
    public class Solution
    {
        public string[] solution(string[] names)
        {
            List<string> list = new List<string>(names);

            return list.Where(x => list.IndexOf(x) % 5 == 0).ToArray();
        }
    }
}
