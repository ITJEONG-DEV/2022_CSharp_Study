using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.프로그래머스
{
    internal class 숫자_문자열과_영단어
    {
        public class Solution
        {
            public int solution(string s)
            {
                string[] arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

                for(int i = 0; i < arr.Length; i++)
                {
                    int index = s.IndexOf(arr[i]);
                    while(index != -1)
                    {
                        if (index != -1)
                            s = s.Substring(0, index) + (i).ToString() + s.Substring(index + arr[i].Length);

                        index = s.IndexOf(arr[i]);
                    }
                }
                return int.Parse(s);
            }

            public static void Main(string[] args)
            {
                Solution s = new Solution();

                Console.WriteLine(s.solution("one4seveneightzero"));
            }
        }
    }
}
