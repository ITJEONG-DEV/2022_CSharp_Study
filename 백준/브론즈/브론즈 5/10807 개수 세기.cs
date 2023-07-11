using System;

namespace 백준.Bronze.개수_세기
{
    class Solution
    {
        static void main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var words = Console.ReadLine().Split(' ');

            int v = int.Parse(Console.ReadLine());

            int count = 0;
            for(int i=0; i<words.Length; i++)
            {
                if (int.Parse(words[i]) == v) count++;
            }

            Console.WriteLine(count);
        }
    }
}
