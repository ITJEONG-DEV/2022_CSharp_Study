using System;

namespace 백준.Bronze.두_수_비교하기
{
    class Solution
    {
        static void main(string[] args)
        {
            string[] word = Console.ReadLine().Trim().Split();

            int a = int.Parse(word[0]);
            int b = int.Parse(word[1]);

            if (a < b) Console.WriteLine("<");
            else if(a==b) Console.WriteLine("==");
            else Console.WriteLine(">");
        }
    }
}
