using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.게입_맵_최단거리
{


    class Solution
    {
        public class Vector2
        {
            public int x;
            public int y;
            public Vector2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static Vector2 operator +(Vector2 a, Vector2 b)
            {
                return new Vector2(a.x + b.x, a.y + b.y);
            }

            public bool Equals(Vector2 v)
            {
                return x == v.x && y == v.y;
            }
        }

        public List<Vector2> directions = new List<Vector2>()
        {
            new Vector2(0, 1),
            new Vector2(0, -1),
            new Vector2(1, 0),
            new Vector2(-1, 0)
        };

        public bool CheckVisited(Vector2 n, ref int[,] maps, ref bool[,] visited)
        {
            if (n.x < 0 || n.y < 0 || n.x > visited.GetLength(1) - 1 || n.y > visited.GetLength(0) - 1) return true;
            if (maps[n.y, n.x] == 0) return true;

            return visited[n.y, n.x];
        }

        public int Find(Vector2 v, int score, ref Queue<KeyValuePair<Vector2, int>> queue, ref int[,] maps, ref bool[,] visited)
        {
            int height = maps.GetLength(0);
            int width = maps.GetLength(1);

            var current = new KeyValuePair<Vector2, int>(v, score);
            visited[v.y, v.x] = true;
            Console.WriteLine($"({current.Key.x}, {current.Key.y}) : {current.Value}");

            while (!(current.Key.x == width -1 && current.Key.y == height - 1))
            {
                foreach (var d in directions)
                {
                    Vector2 renew = current.Key + d;

                    if (!CheckVisited(renew, ref maps, ref visited))
                    {
                        var item = new KeyValuePair<Vector2, int>(renew, current.Value + 1);
                        visited[renew.y, renew.x] = true;
                        queue.Enqueue(item);
                    }
                }

                if (queue.Count == 0) return -1;
                current = queue.Dequeue();
                Console.WriteLine($"({current.Key.x}, {current.Key.y}) : {current.Value}");
            }

            return current.Value;
        }

        public int solution(int[,] maps)
        {
            Queue<KeyValuePair<Vector2, int>> queue = new Queue<KeyValuePair<Vector2, int>>();
            bool[,] visited = new bool[maps.GetLength(0), maps.GetLength(1)];

            Vector2 current = new Vector2(0, 0);
            int score = 1;

            return Find(current, score, ref queue, ref maps, ref visited);
        }
    }
}
