using System;
using System.Collections.Generic;
using System.Linq;

namespace 프로그래머스.특이한_정렬
{
    public class Solution
    {
        public int[] solution(int[] numlist, int n)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            foreach (int num in numlist)
            {
                int differ = Math.Abs(n - num);

                if (!dict.ContainsKey(differ))
                {
                    dict.Add(differ, new List<int>());
                }

                dict[differ].Add(num);
            }

            var keyList = dict.Keys.ToList();
            keyList.Sort();

            List<int> result = new List<int>();
            foreach (int key in keyList)
            {
                dict[key].Sort();
                dict[key].Reverse();


                result.AddRange(dict[key]);
            }

            return result.ToArray();
        }
    }
}
