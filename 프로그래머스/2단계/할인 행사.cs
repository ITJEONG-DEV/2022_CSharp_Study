using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.할인_행사
{
    public class Solution
    {
        readonly int term = 10;

        public bool CheckDiscount(int start, string[] discount, Dictionary<string, int> wish_dict)
        {
            for (int i = 0; i < term; i++)
            {
                if (!wish_dict.ContainsKey(discount[start + i])) continue;
                wish_dict[discount[start + i]]--;
            }

            foreach (var item in wish_dict.Keys)
            {
                if (wish_dict[item] > 0) return false;
            }

            return true;
        }
        public int solution(string[] want, int[] number, string[] discount)
        {
            Dictionary<string, int> wish_dict = new Dictionary<string, int>();
            for (int i = 0; i < want.Length; i++)
            {
                if (!discount.Contains(want[i])) return 0;
                wish_dict[want[i]] = number[i];
            }

            int days = 0;
            for (int i = 0; i < discount.Length - term + 1; i++)
            {
                var copy_dict = wish_dict.ToDictionary(e => e.Key, e => e.Value);
                if (CheckDiscount(i, discount, copy_dict)) days++;
            }

            return days;
        }
    }
}
