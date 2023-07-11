using System;

namespace 백준.Bronze.과제_안_내신_분
{
    class Solution
    {
        static void main(string[] args)
        {
            int[] arr = new int[30];
            for (int i = 0; i < 28; i++)
            {
                int n = int.Parse(Console.ReadLine());

                arr[n - 1] = 1;
            }

            for (int i = 0; i < 30; i++)
                if (arr[i] == 0)
                    Console.WriteLine(i + 1);

        }

    }
}
