using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.당구_연습
{
    public class Solution
    {
        public class Vector2
        {
            public static int m;
            public static int n;
            public int x;
            public int y;
            public Vector2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int Distance(Vector2 a)
            {
                return (this.x - a.x) * (this.x - a.x) + (this.y - a.y) * (this.y - a.y);
            }

            public Vector2 FlipLeft()
            {
                return new Vector2(-this.x, this.y);
            }

            public Vector2 FlipRight()
            {
                return new Vector2(2 * Vector2.m - this.x, this.y);
            }

            public Vector2 FlipUp()
            {
                return new Vector2(this.x, -this.y);
            }

            public Vector2 FlipDown()
            {
                return new Vector2(this.x, 2 * Vector2.m - this.y);
            }
        }
        public int[] solution(int m, int n, int startX, int startY, int[,] balls)
        {
            Vector2.m = m;
            Vector2.n = n;
            List<int> result = new List<int>();

            for (int i = 0; i < balls.GetLength(0); i++)
            {
                Vector2 start = new Vector2(startX, startY);
                Vector2 ball = new Vector2(balls[i, 0], balls[i, 1]);

                var list = new List<int>
                {
                    start.Distance(ball.FlipLeft()),
                    start.Distance(ball.FlipRight()),
                    start.Distance(ball.FlipUp()),
                    start.Distance(ball.FlipDown())
                };

                result.Add(list.Min());
            }

            return result.ToArray();
        }
    }
}
