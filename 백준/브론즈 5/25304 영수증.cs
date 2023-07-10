using System;

namespace 백준.Bronze.영수증
{
    class Solution
    {
        static void main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for(int i=0; i<n; i++)
            {
                var words = Console.ReadLine().Split(' ');

                int a = int.Parse(words[0]);
                int b = int.Parse(words[1]);

                sum += a * b;

                if(x < sum)
                    break;
            }

            if (x == sum)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
