using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.교점에_별_만들기
{
    public class Solution
    {
        public class Point
        {
            public long X { get; set; }
            public long Y { get; set; }

            public Point(long x, long y)
            {
                this.X = x;
                this.Y = y;
            }
        }
        public static void Main(string[] args)
        {
            Solution s = new Solution();
            var r = s.solution(new int[,] { { 2, -1, 4 }, { -2, -1, 4 }, { 0, -1, 1 }, { 5, -8, -12 }, { 5, 8, 12 } });
            Console.WriteLine(String.Join("\n", r));
        }

        public string[] solution(int[,] line)
        {
            List<Point> points = new List<Point>();
            Point min = new Point(long.MaxValue, long.MaxValue);
            Point max = new Point(long.MinValue, long.MinValue);
            for(int i=0; i<line.GetLength(0); i++)
            {
                long a = line[i, 0];
                long b = line[i, 1];
                long e = line[i, 2];

                for (int j=i+1; j<line.GetLength(0); j++)
                {
                    long c = line[j, 0];
                    long d = line[j, 1];
                    long f = line[j, 2];

                    if (a * d - b * c == 0) continue;

                    double x = (b * f - e * d) / (double)(a * d - b * c);
                    double y = (e * c - a * f) / (double)(a * d - b * c);

                    if(x%1==0.0 && y%1==0.0)
                    {
                        points.Add(new Point((long)x, (long)y));

                        if (min.X > x) min.X = (long)x;
                        if (max.X < x) max.X = (long)x;
                        if (min.Y > y) min.Y = (long)y;
                        if (max.Y < y) max.Y = (long)y;
                    }
                }
            }

            long width = max.X - min.X+1;
            long height = max.Y - min.Y+1;

            StringBuilder[] stringBuilders = new StringBuilder[height];
            for (int i = 0; i < height; i++)
            {
                stringBuilders[i] = new StringBuilder();

                for (int j = 0; j < width; j++)
                    stringBuilders[i].Append('.');
            }


            foreach(var point in points)
            {
                long x = point.X - min.X;
                long y = point.Y - min.Y;

                stringBuilders[(int)y][(int)x] = '*';
            }

            string[] result = new string[height];
            for (int i = 0; i < height; i++)
                result[i] = stringBuilders[height-1-i].ToString();

            return result;
        }
    }
}
