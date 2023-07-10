using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.리코쳇_로봇
{
    public class Solution
    {
        public static void main(string[] args)
        {
            Solution solution = new Solution();
            var r = solution.solution(new string[] { "...D..R", ".D.G...", "....D.D", "D....D.", "..D...." });
            Console.WriteLine($"result: {r}");
        }
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

            public Vector2 Clone()
            {
                return new Vector2(this.x, this.y);
            }

            public bool Equals(Vector2 other)
            {
                if (this.x == other.x && this.y == other.y) return true;
                return false;
            }
        }
        static Vector2[] directions =
        {
            new Vector2(0, -1),
            new Vector2(0, 1),
            new Vector2(-1, 0),
            new Vector2(1, 0)
        };

        // 이동가능한 좌표인지 확인한다
        public bool CheckMovable(int x, int y, ref string[] board)
        {
            if (x < 0) return false;
            if (x > board[0].Length - 1) return false;
            if (y < 0) return false;
            if (y > board.Length - 1) return false;

            if (board[y][x] == 'D') return false;

            return true;
        }

        // 도달할 수 있는 골인지 확인한다
        // 상/하/좌/우 가 모두 뚫려 있거나, 모두 막힌 경우가 아니면 도달할 수 있다고 봄
        public bool IsReachable(Vector2 g, ref string[] board)
        {
            int count = 0;
            for (int i = 0; i < directions.Length; i++)
                if (!CheckMovable(g.x + directions[i].x, g.y + directions[i].y, ref board))
                    count++;

            if (count == 0 || count == 4) return false;
            return true;
        }

        public Vector2 Shift(Vector2 origin, Vector2 direction, ref string[] board)
        {
            Vector2 v = origin.Clone();

            while (CheckMovable(v.x + direction.x, v.y + direction.y, ref board))
            {
                v += direction;
            }

            return v;
        }

        public int solution(string[] board)
        {
            Vector2 robot = new Vector2(0, 0);
            Vector2 goal = new Vector2(0, 0);

            bool findRobot = false;
            bool findGoal = false;
            for (int i = 0; i < board.Length; i++)
            {
                if (findRobot && findGoal) break;

                for (int j = 0; j < board[i].Length; j++)
                {
                    if (findRobot && findGoal) break;

                    if (board[i][j] == 'R')
                    {
                        robot.x = j;
                        robot.y = i;
                        findRobot = true;
                        continue;
                    }

                    else if (board[i][j] == 'G')
                    {
                        goal.x = j;
                        goal.y = i;
                        findGoal = true;
                        continue;
                    }
                }
            }

            if (!IsReachable(goal, ref board)) return -1;

            Queue<KeyValuePair<Vector2, int>> routes = new Queue<KeyValuePair<Vector2, int>>();
            bool[,] visited = new bool[board.Length, board[0].Length];
            visited[robot.y, robot.x] = true;

            int d = 0;
            while (!robot.Equals(goal))
            {
                foreach (Vector2 direction in directions)
                {
                    Vector2 movedPos = Shift(robot, direction, ref board);

                    if (!visited[movedPos.y, movedPos.x])
                    {
                        // Console.WriteLine($"({robot.x}, {robot.y}) > ({movedPos.x}, {movedPos.y}), d: {d+1}");
                        visited[movedPos.y, movedPos.x] = true;
                        routes.Enqueue(new KeyValuePair<Vector2, int>(movedPos, d+1));
                    }
                }

                if (routes.Count == 0) return -1;

                var item = routes.Dequeue();
                robot = item.Key;
                d = item.Value;
            }

            return d;
        }
    }
}
