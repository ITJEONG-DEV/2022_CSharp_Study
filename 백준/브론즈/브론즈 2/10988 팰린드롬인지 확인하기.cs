using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준.Bronze.팰린드롬인지_확인하기
{
    class Solution
    {
        static void main(string[] args)
        {
            var s = Console.ReadLine().Trim();

            int left = 0;
            int right= s.Length - 1;

            while(left < right)
            {
                if (s[left] != s[right])
                {
                    Console.WriteLine(0);
                    return;
                }
                left++;
                right--;
            }

            Console.WriteLine(1);
        }
    }
}
