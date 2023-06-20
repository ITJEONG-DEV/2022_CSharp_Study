using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.잘라서_배열로_저장하기
{
    public class Solution
    {
        public string[] solution(string my_str, int n)
        {
            int length = my_str.Length / n;
            if (my_str.Length % n != 0) length++;

            string[] result = new string[length];

            for (int i = 0; i < length; i++)
            {
                if (i == length - 1)
                {
                    result[i] = my_str.Substring(n * i, my_str.Length - n * i);
                }
                else
                {
                    result[i] = my_str.Substring(n * i, n);
                }
            }

            return result;
        }
    }
}
