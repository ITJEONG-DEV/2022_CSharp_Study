using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 프로그래머스.시소_짝꿍
{
    public class Solution
    {
        public long solution(int[] weights)
        {
            Dictionary<int, long> weightDict = new Dictionary<int, long>();
            for (int i = 0; i < weights.Length; i++)
            {
                if (!weightDict.ContainsKey(weights[i]))
                    weightDict[weights[i]] = 0;

                weightDict[weights[i]]++;
            }

            long count = 0;
            foreach (int key in weightDict.Keys)
            {
                // a == a
                if (weightDict[key] > 1) count += weightDict[key] * (weightDict[key] - 1) / 2;

                // min * 4 == max * 2
                int newKey = key * 4 / 2;
                if (weightDict.ContainsKey(newKey)) count += weightDict[key] * weightDict[newKey];

                // min * 4 == max * 3
                newKey = key * 4 / 3;
                if (key % 3 == 0 && weightDict.ContainsKey(newKey)) count += weightDict[key] * weightDict[newKey];

                // min * 3 == max * 2
                newKey = key * 3 / 2;
                if (key % 2 == 0 && weightDict.ContainsKey(newKey)) count += weightDict[key] * weightDict[newKey];
            }

            return count;
        }
    }
}
