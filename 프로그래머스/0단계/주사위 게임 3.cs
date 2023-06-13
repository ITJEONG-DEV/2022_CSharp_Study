using System;
using System.Linq;

namespace 프로그래머스.주사위_게임_3
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

        public override string ToString()
        {
            return "(" + Value + ":" + Count + ")";
        }
    }
    public class Solution
    {
        public int solution(int a, int b, int c, int d)
        {
            int[] arr = { a, b, c, d };

            var duplicates = arr.GroupBy(x => x)
                .Where(g => g.Count() >= 1)
                .Select(y => new Item(y.Key, y.Count()))
                .ToList();

            duplicates.Sort(new Comparison<Item>((i1, i2) => i2.Count.CompareTo(i1.Count)));

            //Console.WriteLine(String.Join("\n", duplicates));

            // a = b = c = d
            if (duplicates.Count == 1)
            {
                return 1111 * duplicates[0].Value;
            }
            // a = b, c = d
            else if (duplicates.Count == 2 && duplicates[0].Count == 2)
            {
                return (duplicates[0].Value + duplicates[1].Value) * Math.Abs(duplicates[0].Value - duplicates[1].Value);
            }
            // a, b = c = d
            else if (duplicates.Count == 2)
            {
                return (duplicates[0].Value * 10 + duplicates[1].Value) * (duplicates[0].Value * 10 + duplicates[1].Value);
            }
            else if (duplicates.Count == 3)
            {
                return duplicates[1].Value * duplicates[2].Value;
            }
            // a, b, c, d
            else
            {
                return arr.Min();
            }
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine(solution.solution(2, 2, 2, 2));
            Console.WriteLine(solution.solution(4, 1, 4, 4));
            Console.WriteLine(solution.solution(6, 3, 3, 6));
            Console.WriteLine(solution.solution(2, 5, 2, 6));
            Console.WriteLine(solution.solution(6, 4, 2, 5));
            Console.WriteLine(solution.solution(6, 1, 3, 3));

            Console.WriteLine("hhhh");

        }
    }
}
