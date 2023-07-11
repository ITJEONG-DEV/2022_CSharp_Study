using System;

namespace 백준.Bronze.최댓값
{
    class Solution
    {
        static void main(string[] args)
        {
            int max = int.MinValue;
            int index = -1;
            for(int i=0; i<9; i++)
            {
                int n =int.Parse(Console.ReadLine());

                if(n > max)
                {
                    max = n;
                    index = i + 1;
                }
            }

            Console.WriteLine($"{max}\n{index}");
        }
    }
}
