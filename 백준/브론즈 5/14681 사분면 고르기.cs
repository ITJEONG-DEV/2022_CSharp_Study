using System;

namespace 백준.Bronze.사분면_고르기
{
    class Solution
    {
        static void main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0) Console.WriteLine("1");
            else if (a < 0 && b > 0) Console.WriteLine("2");
            else if (a < 0 && b < 0) Console.WriteLine("3");
            else if (a > 0 && b < 0) Console.WriteLine("4");
        }
    }
}
