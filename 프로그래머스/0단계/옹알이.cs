using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.옹알이
{
    public class Solution
    {
        public int solution(string[] babbling)
        {
            var result = 0;
            String[] list = { "aya", "ye", "woo", "ma" };
            for (int i = 0; i < babbling.Length; i++)
            {
                var word = babbling[i];

                for (int j = 0; j < list.Length; j++)
                {
                    word = word.Replace(list[j], "_");
                }

                word = word.Replace("_", "");

                if (word.Length == 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
