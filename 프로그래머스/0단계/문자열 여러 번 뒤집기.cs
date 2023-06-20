using CSharp.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.문자열_여러_번_뒤집기
{
    public class Solution
    {
        public string GetReverseString(string str)
        {
            return string.Concat(str.Reverse());
        }
        public string solution(string my_string, int[,] queries)
        {
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                if (queries[i, 0] == queries[i, 1])
                {
                    continue;
                }
                else if (queries[i, 0] == 0 && queries[i, 1] == my_string.Length - 1)
                {
                    var substring = GetReverseString(my_string.Substring(queries[i, 0], queries[i, 1] - queries[i, 0] + 1));

                    my_string = substring;
                }
                else if (queries[i, 0] == 0)
                {
                    var substring = GetReverseString(my_string.Substring(queries[i, 0], queries[i, 1] - queries[i, 0] + 1));

                    my_string = substring + my_string.Substring(queries[i, 1] + 1);
                }
                else if (queries[i, 1] == my_string.Length - 1)
                {
                    var substring = GetReverseString(my_string.Substring(queries[i, 0], queries[i, 1] - queries[i, 0] + 1));

                    my_string = my_string.Substring(0, queries[i, 0]) + substring;
                }
                else
                {
                    var substring = GetReverseString(my_string.Substring(queries[i, 0], queries[i, 1] - queries[i, 0] + 1));

                    my_string = my_string.Substring(0, queries[i, 0]) + substring + my_string.Substring(queries[i, 1] + 1);
                }
            }

            return my_string;
        }
    }
}
