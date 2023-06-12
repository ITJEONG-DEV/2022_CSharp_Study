using System;

namespace 프로그래머스.문자열_반복해서_출력하기
{
    public class Solution
    {
        public static void Main()
        {
            String[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');

            String s1 = input[0];
            int a = Int32.Parse(input[1]);

            for (int i = 0; i < a; i++)
                Console.Write(s1);

        }
    }
}
