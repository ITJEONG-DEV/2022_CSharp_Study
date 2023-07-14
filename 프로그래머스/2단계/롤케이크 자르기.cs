using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 프로그래머스.롤케이크_자르기
{
    public class Solution
    {
        public int solution(int[] topping)
        {
            Dictionary<int, int> toppingDict = new Dictionary<int, int>();

            for(int i=0; i<topping.Length; i++)
            {
                if (!toppingDict.ContainsKey(topping[i]))
                    toppingDict[topping[i]] = 0;

                toppingDict[topping[i]]++;
            }

            int count = 0;

            int left = toppingDict.Keys.Count;
            Dictionary<int, int> rightDict = new Dictionary<int, int>();
            int right = 0;
            for(int i = topping.Length-1; i>=0; i--)
            {
                if (!rightDict.ContainsKey(topping[i]))
                {
                    rightDict[topping[i]] = 0;
                    right++;
                }

                rightDict[topping[i]]++;
                toppingDict[topping[i]]--;

                if (toppingDict[topping[i]] == 0)
                    left--;

                if (left == right) count++;
            }

            return count;
        }
    }
}
