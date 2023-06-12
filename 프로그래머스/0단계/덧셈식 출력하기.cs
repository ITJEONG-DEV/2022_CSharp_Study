using System;

namespace 프로그래머스.덧셈식_출력하기
{
    public class Solution
    {
        public static void main()
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
    }
}
