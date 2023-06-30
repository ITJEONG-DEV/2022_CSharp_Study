using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.최댓값과_최솟값
{
    public class Solution
    {
        public string solution(string s)
        {
            string[] arr = s.Split(' ');

            int min = int.MaxValue;
            int max = int.MinValue;

            foreach(string item in arr)
            {
                int n = int.Parse(item);

                if(n < min) min = n;
                if(n > max) max = n;
            }

            return $"{min} {max}";
        }
    }
}
