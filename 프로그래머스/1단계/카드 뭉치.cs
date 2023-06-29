using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.카드_뭉치
{
    public class Solution
    {
        public string solution(string[] cards1, string[] cards2, string[] goal)
        {
            Queue<string> c1 = new Queue<string>(cards1);
            Queue<string> c2 = new Queue<string>(cards2);
            Queue<string> g = new Queue<string>(goal);

            while(g.Count > 0)
            {
                if(0 < c1.Count && g.Peek() == c1.Peek())
                {
                    c1.Dequeue();
                    g.Dequeue();
                }
                else if(0 < c2.Count && g.Peek() == c2.Peek())
                {
                    c2.Dequeue();
                    g.Dequeue();
                }
                else
                {
                    return "No";
                }
            }

            return "Yes";
        }
    }
}
