using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.혼자_놀기의_달인
{
    public class Solution
    {
        public int solution(int[] cards)
        {
            bool[] visited = new bool[cards.Length];

            int n = -1;

            List<int> groups = new List<int>();
            for (int i = 0; i < cards.Length; i++)
            {
                if (!visited[i])
                {
                    groups.Add(0);

                    // Console.WriteLine($"visited: {i+1}, {cards[i]}");
                    visited[i] = true;
                    groups[groups.Count - 1]++;
                    n = cards[i];

                    while (!visited[n - 1])
                    {
                        // Console.WriteLine($"visited: {n}, {cards[n-1]}");
                        visited[n - 1] = true;
                        groups[groups.Count - 1]++;
                        n = cards[n - 1];
                    }
                    // Console.WriteLine("end");
                }
            }

            if (groups.Count == 1) return 0;

            groups.Sort();

            return groups[groups.Count - 1] * groups[groups.Count - 2];
        }
    }
}
