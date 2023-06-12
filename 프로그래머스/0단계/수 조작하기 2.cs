using System;
using System.Text;
using System.Linq;

namespace 프로그래머스.수_조작하기_2
{
    public class Solution
    {
        public string solution(int[] numLog)
        {
            var result = new StringBuilder();

            for (int i = 0; i < numLog.Length - 1; i++)
            {
                var differ = numLog[i + 1] - numLog[i];

                switch (differ)
                {
                    case 1:
                        result.Append("w");
                        break;
                    case -1:
                        result.Append("s");
                        break;
                    case 10:
                        result.Append("d");
                        break;
                    case -10:
                        result.Append("a");
                        break;
                }
            }

            return result.ToString();
        }
    }
}
