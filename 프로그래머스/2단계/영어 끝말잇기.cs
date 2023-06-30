using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.영어_끝말잇기
{
    class Solution
    {
        public int[] solution(int n, string[] words)
        {
            Dictionary<string, bool> doubleCheck = new Dictionary<string, bool>();

            int person = 1;
            int turn = 1;
            char alphabet = '0';

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (i != 0 && word[0] != alphabet)
                {
                    return new int[2] { person, turn };
                }

                alphabet = word[word.Length - 1];

                if (doubleCheck.ContainsKey(word))
                {
                    return new int[2] { person, turn };
                }
                else
                {
                    doubleCheck[word] = true;
                }

                person++;

                if (person > n)
                {
                    turn++;
                    person -= n;
                }
            }

            return new int[2] { 0, 0 };
        }
    }
}
