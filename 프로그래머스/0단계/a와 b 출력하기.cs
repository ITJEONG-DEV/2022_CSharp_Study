using System;

namespace 프로그래머스.a와_b_출력하기
{
    public class Solution
    {
        public static void Main()
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            Console.WriteLine("a = {0}\nb = {1}", a, b);
        }

    }
}