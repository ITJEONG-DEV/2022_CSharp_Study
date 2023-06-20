using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.외계어_사전
{
    public class Solution
    {
        public int solution(string[] spell, string[] dic)
        {
            foreach (var word in dic)
            {
                if (spell.Length != word.Length)
                {
                    continue;
                }

                var flag = true;
                foreach (var alphabet in spell)
                {
                    if (!word.Contains(alphabet))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) return 1;
            }

            return 2;
        }
    }
}
