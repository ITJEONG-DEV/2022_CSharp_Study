using System;

namespace 백준.Bronze.공_넣기
{
    class Solution
    {
        static void main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');
            int n = int.Parse(words[0]);
            int m = int.Parse(words[1]);

            int[] arr = new int[n];
            for (int i = 0; i < m; i++)
            {
                words = Console.ReadLine().Split(' ');

                int a = int.Parse(words[0]);
                int b = int.Parse(words[1]);
                int c = int.Parse(words[2]);

                for (int j = a - 1; j <= b - 1; j++)
                    arr[j] = c;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
