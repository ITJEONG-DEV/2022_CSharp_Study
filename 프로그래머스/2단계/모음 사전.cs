using System;
using System.Collections.Generic;

namespace 프로그래머스.모음_사전
{
    public class Solution
    {
        public int solution(string word)
        {
            List<char> chars = new List<char>() { 'A', 'E', 'I', 'O', 'U' };

            int n = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                int index = chars.IndexOf(c);

                int sum = 0;
                for (int j = 0; j < chars.Count - i; j++)
                    sum += (int)Math.Pow(5, j);

                n += sum * index + 1;
            }

            return n;
        }
    }
}
