using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.귤_고르기
{
    public class Item
    {
        public int size;
        public int count;
        public Item(int size, int count)
        {
            this.size = size;
            this.count = count;
        }
    }
    public class Solution
    {
        public int solution(int k, int[] tangerine)
        {
            var duplicates = tangerine.GroupBy(x => x)
                .Where(g => g.Count() >= 1)
                .Select(y => new Item(y.Key, y.Count()))
                .ToList();

            duplicates.Sort(new Comparison<Item>((i1, i2) => i2.count.CompareTo(i1.count)));

            int count = 0;
            int i = 0;
            for(; i<duplicates.Count; i++)
            {
                count += duplicates[i].count;

                if (count >= k)
                    break;
            }

            return i+1;
        }
    }
}
