using System;

namespace 백준.Bronze.A_B_7
{
    class Solution
    {
        static void main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                var words = Console.ReadLine().Split(' ');

                int a = int.Parse(words[0]);
                int b = int.Parse(words[1]);

                Console.WriteLine($"Case #{i+1}: {a+b}");

            }
        }
    }
}
