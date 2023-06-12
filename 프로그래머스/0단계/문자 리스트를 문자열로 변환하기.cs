using System;
using System.Text;
using System.Linq;

namespace 프로그래머스.문자_리스트를_문자열로_변환하기
{
    public class Solution
    {
        public string solution(string[] arr)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                result.Append(arr[i]);
            }

            return result.ToString();
        }
    }
}
