using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.옹알이_2
{
    public class Solution
    {
        public int solution(string[] babbling)
        {
            int count = 0;

            foreach(string word in babbling)
            {
                if (word.Contains("ayaaya") || word.Contains("yeye") || word.Contains("woowoo") || word.Contains("mama"))
                    continue;

                string w = word.Replace("ma", "_");
                w = w.Replace("woo", "_");
                w = w.Replace("ye", "_");
                w = w.Replace("aya", "_");

                w = w.Replace("_", "");

                if ( w.Count() == 0 ) {
                    count++;
                }
            }

            return count;
        }
    }
}
