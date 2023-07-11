using System;

namespace 백준.Bronze.A_B_5
{
    class Solution
    {
        static void main(string[] args)
        {
            for(; ; )
            {
                var words = Console.ReadLine().Split(' ');

                int a = int.Parse(words[0]);
                int b = int.Parse(words[1]);

                if (a == 0 && b == 0) return;

                Console.WriteLine($"{a+b}");

            }
        }
    }
}
