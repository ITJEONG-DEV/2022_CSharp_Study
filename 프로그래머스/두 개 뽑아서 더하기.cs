using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.두_개_뽑아서_더하기
{
    class Solution
    {
        public int[] solution(int[] numbers)
        {
            SortedSet<int> result = new SortedSet<int>();

            for(int i=0; i < numbers.Length; i++)
                for(int j=i+1; j<numbers.Length; j++)
                    result.Add(numbers[i]+numbers[j]);

            return result.ToArray();
        }
    }
}
