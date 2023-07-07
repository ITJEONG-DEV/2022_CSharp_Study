using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.주식가격
{
    public class Solution
    {
        public int[] solution(int[] prices)
        {
            int[] result = new int[prices.Length];

            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j <= prices.Length; j++)
                {
                    if (j == prices.Length) result[i] = prices.Length - i - 1;
                    else if (prices[i] > prices[j])
                    {
                        result[i] = j - i;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
