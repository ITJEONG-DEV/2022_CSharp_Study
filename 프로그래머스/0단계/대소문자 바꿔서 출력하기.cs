using System;
using System.Linq;

namespace 프로그래머스.대소문자_바꿔서_출력하기
{
    public class Solution
    {
        public static void Main()
        {
            String s;

            Console.Clear();
            s = Console.ReadLine();

            var result = s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)).ToArray();

            Console.WriteLine(new String(result));

        }
    }
}
