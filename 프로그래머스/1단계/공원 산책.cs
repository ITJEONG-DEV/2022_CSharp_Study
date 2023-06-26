using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.공원_산책
{
    public class Vector2
    {
        public int X;
        public int Y;

        public Vector2(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X + b.X, a.Y + b.Y);
        }
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X - b.X, a.Y - b.Y);
        }
        public static Vector2 operator *(Vector2 a, int b)
        {
            return new Vector2(a.X * b, a.Y * b);
        }

        public int[] ToArray()
        {
            return new int[] { Y, X };
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

    }

    public class Solution
    {
        public Vector2 GetDirection(string s)
        {
            switch (s)
            {
                case "N":
                    return new Vector2(0, -1);
                case "W":
                    return new Vector2(-1, 0);
                case "E":
                    return new Vector2(1, 0);
                case "S":
                    return new Vector2(0, 1);
            }

            return new Vector2();
        }

        public bool CheckRoute(Vector2 direction, int distance, Vector2 pos, string[] park)
        {
            int width = park[0].Length, height = park.Length;

            for (int i = 0; i < distance; i++)
            {
                pos += direction;

                if (pos.X < 0 || pos.X >= width || pos.Y < 0 || pos.Y >= height)
                {
                    return false;
                }

                if (park[pos.Y][pos.X] == 'X')
                {
                    return false;
                }
            }

            return true;
        }
        public int[] solution(string[] park, string[] routes)
        {
            Vector2 position = new Vector2();

            for (int i = 0; i < park.Length; i++)
            {
                if (park[i].Contains("S"))
                {
                    position.X = park[i].IndexOf("S");
                    position.Y = i;
                }
            }

            foreach (string route in routes)
            {
                var r = route.Split(' ');

                var direction = GetDirection(r[0]);
                var distance = int.Parse(r[1]);

                if (CheckRoute(direction, distance, position, park))
                {
                    position += direction * distance;
                }
            }

            return position.ToArray();
        }
    }
}
