using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.최빈값_구하기
{
    public class Item
    {
        public Item(int value, int count)
        {
            this.Value = value;
            this.Count = count;
        }
        public int Value;
        public int Count;
    }

    public class Solution
    {
        public int solution(int[] array)
        {
            if (array.Length == 1)
            {
                return array[0];
            }
            else if (array.Length == 2)
            {
                if (array[0] == array[1])
                {
                    return array[0];
                }
                else
                {
                    return -1;
                }
            }

            var duplicates = array.GroupBy(x => x)
                .Where(g => g.Count() > 0)
                .Select(y => new Item(y.Key, y.Count()))
                .ToList();


            if (duplicates.Count == 1)
            {
                return duplicates[0].Value;
            }

            duplicates.Sort(new Comparison<Item>((i1, i2) => i2.Count.CompareTo(i1.Count)));

            if (duplicates[0].Count == duplicates[1].Count)
            {
                return -1;
            }
            else
            {
                return duplicates[0].Value;
            }
        }
    }
}
