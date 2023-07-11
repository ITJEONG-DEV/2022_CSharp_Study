using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준.Bronze.바구니_뒤집기
{
    class Solution
    {
        static void main(string[] args)
        {
            var words = Console.ReadLine().Trim().Split();

            int n = int.Parse(words[0]);
            int m = int.Parse(words[1]);

            int[] arr = new int[n];
            for (int i = 0; i < n; i++) arr[i] = i+1;

            for(int i=0; i<m; i++)
            {
                words = Console.ReadLine().Trim().Split();

                int a = int.Parse(words[0]) - 1;
                int b = int.Parse(words[1]) - 1;

                for(int j = a; j<=(a+b)/2; j++)
                {
                    int k = arr[j];
                    arr[j] = arr[b-(j-a)];
                    arr[b-(j-a)] = k;
                }
            }

            for (int i = 0; i < n; i++)
                Console.Write($"{arr[i]} ");
        }
    }
}
