using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 프로그래머스.피로도
{
    public class Solution
    {
        public class Dungeon
        {
            public int required;
            public int used;
            public Dungeon(int required, int used)
            {
                this.required = required;
                this.used = used;
            }
        }
        public int ExploreDungeon(int k, int count, ref List<Dungeon> list, bool[] visited)
        {
            List<int> numList = new List<int>();

            for(int i=0; i<list.Count; i++)
            {
                if (visited[i]) continue;

                if (k >= list[i].required && k >= list[i].used)
                {
                    bool[] newVisited = (bool[])visited.Clone();
                    newVisited[i] = true;

                    numList.Add(ExploreDungeon(k - list[i].used, count + 1, ref list, newVisited));
                }
            }

            if (numList.Count == 0) return count;

            return numList.Max();

        }
        public int solution(int k, int[,] dungeons)
        {
            List<Dungeon> dungeonList = new List<Dungeon>();
            for (int i = 0; i < dungeons.GetLength(0); i++)
            {
                var dungeon = new Dungeon(dungeons[i, 0], dungeons[i, 1]);
                dungeonList.Add(dungeon);
            }

            dungeonList.Sort(new Comparison<Dungeon>(
                    (d1, d2) =>
                        d1.required == d2.required ? d2.used - d1.used : d2.required - d1.required
                )
            );

            bool[] visited = new bool[dungeonList.Count];   
            int num = ExploreDungeon(k, 0, ref dungeonList, visited);

            return num;
        }
    }
}
