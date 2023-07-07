using System;

namespace 백준.Bronze.꼬마_정민
{
    class Solution
    {
        static void main(string[] args)
        {
            string[] word = Console.ReadLine().Trim().Split();

            long result = 0;

            for(int i=0; i<word.Length; i++)
            {
                result += long.Parse(word[i]);
            }

            Console.WriteLine(result);
        }
    }
}
