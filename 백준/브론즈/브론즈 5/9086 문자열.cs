using System;

namespace 백준.Bronze.문자열
{
    class Solution
    {
        static void main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i=0; i<t; i++)
            {
                string s = Console.ReadLine().Trim();
                Console.WriteLine($"{s[0]}{s[s.Length - 1]}");

            }
        }
    }
}
