using System;

namespace 백준.Bronze.최소_최대
{
    class Solution
    {
        static void main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            var words = Console.ReadLine().Split(' ');

            int min = int.MaxValue;
            int max = int.MinValue;

            for(int i=0; i<words.Length; i++)
            {
                int n = int.Parse((words[i]).Trim());
                if (min > n) min = n;
                if(max < n) max = n;
            }

            Console.WriteLine($"{min} {max}");
        }
    }
}
