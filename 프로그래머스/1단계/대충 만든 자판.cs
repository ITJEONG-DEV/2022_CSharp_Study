using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.대충_만든_자판
{
    public class Solution
    {
        public int[] solution(string[] keymap, string[] targets)
        {
            List<int> result = new List<int>();

            foreach(string target in targets)
            {
                int count = 0;
                foreach(char key in target)
                {
                    List<int> cases = new List<int>();

                    foreach(string button in keymap)
                    {
                        if(button.Contains(key))
                        {
                            cases.Add(button.IndexOf(key)+1);
                        }
                    }

                    if(cases.Count == 0)
                    {
                        count = -1;
                        break;
                    }
                    else
                    {
                        count += cases.Min();
                    }
                }

                result.Add(count);
            }

            return result.ToArray();
        }
    }
}
