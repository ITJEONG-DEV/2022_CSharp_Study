using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.무인도_여행
{
    public class Solution
    {
        public bool IsNumber(char c)
        {
            return c > '0' && c < '9';
        }
        public int Explore(int x, int y, ref string[] maps, ref bool[,] explore_map)
        {
            if (explore_map[y, x]) return 0;

            int score = 0;

            score += maps[y][x] - '0';
            explore_map[y, x] = true;

            if (y > 0)
                score += Explore(x, y - 1, ref maps, ref explore_map);

            if (y < maps.Length)
                score += Explore(x, y + 1, ref maps, ref explore_map);

            if (x > 0)
                score += Explore(x - 1, y, ref maps, ref explore_map);

            if (x < maps[0].Length)
                score += Explore(x + 1, y, ref maps, ref explore_map);

            return score;

        }
        public int[] solution(string[] maps)
        {
            List<int> result= new List<int>();

            bool[,] explore_map = new bool[maps.Length, maps[0].Length];

            for(int i=0; i<maps.Length; i++)
                for(int j=0; j < maps[i].Length; j++)
                {
                    if (!explore_map[i, j])
                    {
                        if (IsNumber(maps[i][j]))
                        {
                            int score = Explore(j, i, ref maps, ref explore_map);

                            if(score != 0)
                                result.Add(score);
                        }
                    }
                }

            if (result.Count == 0)
                return new int[] { -1 };

            result.Sort();
            return result.ToArray();
        }
    }
}
