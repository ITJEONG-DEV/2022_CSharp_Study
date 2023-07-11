using System;

namespace 백준.Bronze.문자와_문자열
{
    class Solution
    {
        static void main(string[] args)
        {
            string s = Console.ReadLine().Trim();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(s[n-1]);
        }
    }
}
