using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 프로그래머스.공원_산책;

namespace 프로그래머스.미로_탈출
{
    public class Solution
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

            public static Vector2 operator +(Vector2 v1, Vector2 v2)
            {
                return new Vector2(v1.x+v2.x, v1.y+v2.y);
            }

            public bool Equals(Vector2 v)
            {
                return this.x == v.x && this.y == v.y;
            }
        }

        public static Vector2[] directions =
        {
            new Vector2(-1, 0),
            new Vector2(1, 0),
            new Vector2(0, 1),
            new Vector2(0, -1)
        };

        public bool Moveable(int x, int y, ref string[] maps, ref bool[,] visited)
        {
            if (x < 0) return false;
            if (x > maps[0].Length-1) return false;
            if (y < 0) return false;
            if (y > maps.Length - 1) return false;

            if (maps[y][x] == 'X') return false;

            if (visited[y, x]) return false;

            return true;
        }

        public bool Reachable(int x, int y, ref string[] maps, ref bool[,] visited)
        {
            int count = 0;
            foreach(var direction in directions)
            {
                if (Moveable(x, y, ref maps, ref visited)) count++;
            }

            if (count == 0) return false;

            return true;
        }

        public int FindRoot(Vector2 start, Vector2 end, ref string[] maps)
        {
            bool[,] visited = new bool[maps.Length, maps[0].Length];

            Queue<KeyValuePair<Vector2, int>> route = new Queue<KeyValuePair<Vector2, int>>();
            visited[start.y, start.x] = true;

            int time = 0;
            while (start != end)
            {
                foreach (var direction in directions)
                {
                    var newPos = start + direction;

                    if (Moveable(newPos.x, newPos.y, ref maps, ref visited))
                    {
                        if (newPos.Equals(end)) return time + 1;
                        visited[newPos.y, newPos.x] = true;
                        route.Enqueue(new KeyValuePair<Vector2, int>(newPos, time + 1));
                    }
                }

                if (route.Count == 0) return -1;

                var item = route.Dequeue();

                start = item.Key;
                time = item.Value;
            }

            return time;
        }

        public int solution(string[] maps)
        {
            Vector2 start = new Vector2(0, 0);
            Vector2 wayPoint = new Vector2(0, 0);
            Vector2 end = new Vector2(0, 0);

            bool findStart = false;
            bool findEnd  = false;
            bool findWayPoint = false;

            for(int y=0; y<maps.Length; y++)
            {
                if (findStart && findEnd && findWayPoint) break;

                for(int x=0; x < maps[y].Length; x++)
                {
                    if (findStart && findEnd && findWayPoint) break;

                    if (maps[y][x] == 'S')
                    {
                        start.x = x;
                        start.y = y;
                        findStart = true;
                        continue;
                    }

                    else if (maps[y][x] == 'E')
                    {
                        end.x = x;
                        end.y = y;
                        findEnd = true;
                        continue;
                    }

                    else if (maps[y][x] == 'L')
                    {
                        wayPoint.x = x;
                        wayPoint.y = y;
                        findWayPoint = true;
                        continue;
                    }
                }
            }

            int t1 = FindRoot(start, wayPoint, ref maps);
            if (t1 == -1) return -1;

            int t2 = FindRoot(wayPoint, end, ref maps);
            if (t2 == -1) return -1;


            return t1+t2;
        }
    }
}
