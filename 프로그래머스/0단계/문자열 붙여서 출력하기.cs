using System;

namespace 프로그래머스.문자열_붙여서_출력하기
{
    public class Solution
    {
        public static void Main()
        {
            String[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');

            String s1 = input[0];
            String s2 = input[1];

            Console.Write(s1 + s2);

        }
    }
}
