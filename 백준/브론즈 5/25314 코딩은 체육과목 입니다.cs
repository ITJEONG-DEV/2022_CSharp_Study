using System;

namespace 백준.Bronze.코딩은_체육과목입니다
{
    class Solution
    {
        static void main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 4; i++)
                Console.Write("long ");

            Console.Write("int");
        }
    }
}
