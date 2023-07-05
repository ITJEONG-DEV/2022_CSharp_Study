using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.할_일_목록
{
    public class Solution
    {
        public string[] solution(string[] todo_list, bool[] finished)
        {
            List<string> result = new List<string>();

            for(int i=0; i<todo_list.Length; i++)
            {
                if (!finished[i])
                {
                    result.Add(todo_list[i]);
                }
            }

            return result.ToArray();
        }
    }
}
