using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.가장_큰_수
{
    class Solution
    {

        public int Compare(string a, string b)
        {
            return (a+b).CompareTo(b+a);
        }

        public string solution(int[] numbers)
        {
            if ((from number in numbers where number == 0 select number).Count() == numbers.Length)
                return "0";

            List<string>[] sorted_list = new List<string>[10];
            for (int i = 0; i < 10; i++)
                sorted_list[i] = new List<string>();

            for(int i=0; i<numbers.Length; i++)
            {
                string number = numbers[i].ToString();

                sorted_list[number[0] - '0'].Add(number);
            }

            string answer = "";
            for(int i=9; i>=0; i--)
            {
                sorted_list[i].Sort((x1, x2) => Compare(x1, x2));
                sorted_list[i].Reverse();
                answer += String.Join("", sorted_list[i].ToArray());
            }

            return answer;
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(new int[] { 212, 21 }));
        }
    }
}
