using System;
using System.Text;
using System.Linq;

namespace 프로그래머스.코드_처리하기
{
    public class Solution
    {
        public string solution(string code)
        {
            var ret = new StringBuilder();
            var mode = false;

            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '1')
                {
                    mode = !mode;
                }
                else
                {
                    if (!mode)
                    { // 0
                        if (i % 2 == 0)
                        {
                            ret.Append(code[i]);
                        }
                    }
                    else
                    { // 1
                        if (i % 2 == 1)
                        {
                            ret.Append(code[i]);
                        }
                    }
                }
            }

            var result = ret.ToString();

            if (result.Length == 0)
            {
                return "EMPTY";
            }
            else
            {
                return result;
            }
        }
    }
}
