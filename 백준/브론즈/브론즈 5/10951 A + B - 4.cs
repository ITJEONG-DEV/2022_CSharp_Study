using System;

namespace 백준.Bronze.A_B_4
{
    class Solution
    {
        static void main(string[] args)
        {
            for(; ; )
            {
                var line = Console.ReadLine();
                if (line == null || line.Length == 0) break;

                var words = line.Split(' ');

                int a = int.Parse(words[0]);
                int b = int.Parse(words[1]);

                Console.WriteLine($"{a + b}");
            }
        }
    }
}
