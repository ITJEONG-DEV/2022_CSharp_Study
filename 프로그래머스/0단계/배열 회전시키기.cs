using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.배열_회전시키기
{
    public class Solution
    {
        public int[] solution(int[] numbers, string direction)
        {
            List<int> result = new List<int>(numbers);

            if(direction == "right")
            {
                int n = result[result.Count - 1];

                result.RemoveAt(result.Count - 1);
                result.Insert(0, n);
            }
            else
            {
                int n = result[0];

                result.RemoveAt(0);
                result.Add(n);
            }

            return result.ToArray();
        }
    }
}
