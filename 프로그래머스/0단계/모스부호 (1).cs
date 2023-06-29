using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.모스부호_1
{
    public class Solution
    {
        public string solution(string letter)
        {
            Dictionary<string, char> morse = new Dictionary<string, char>();

            morse[".-"] = 'a';
            morse["-..."] = 'b';
            morse["-.-."] = 'c';
            morse["-.."] = 'd';
            morse["."] = 'e';
            morse["..-."] = 'f';
            morse["--."] = 'g';
            morse["...."] = 'h';
            morse[".."] = 'i';
            morse[".---"] = 'j';
            morse["-.-"] = 'k';
            morse[".-.."] = 'l';
            morse["--"] = 'm';
            morse["-."] = 'n';
            morse["---"] = 'o';
            morse[".--."] = 'p';
            morse["--.-"] = 'q';
            morse[".-."] = 'r';
            morse["..."] = 's';
            morse["-"] = 't';
            morse["..-"] = 'u';
            morse["...-"] = 'v';
            morse[".--"] = 'w';
            morse["-..-"] = 'x';
            morse["-.--"] = 'y';
            morse["--.."] = 'z';

            string[] words = letter.Split(' ');

            List<char> result= new List<char>();
            foreach(string word in words)
            {
                result.Add(morse[word]);
            }

            return String.Join("", result);
        }
    }
}
