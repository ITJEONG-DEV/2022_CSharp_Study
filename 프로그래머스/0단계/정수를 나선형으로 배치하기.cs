using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.정수를_나선형으로_배치하기
{
    public class Solution
    {
        public int[,] solution(int n)
        {
            int[,] answer = new int[n, n];

            int direction = 1;
            int x = 0, y = 0;

            for (int i = 1; i <= n * n; i++)
            {
                answer[y, x] = i;

                if (direction == 1)
                {
                    if (x == n - 1)
                    {
                        direction = 2;
                    }
                    else if (answer[y, x + 1] != 0)
                    {
                        direction = 2;
                    }
                }
                else if (direction == 2)
                {
                    if (y == n - 1)
                    {
                        direction = 3;
                    }
                    else if (answer[y + 1, x] != 0)
                    {
                        direction = 3;
                    }
                }
                else if (direction == 3)
                {
                    if (x == 0)
                    {
                        direction = 4;
                    }
                    else if (answer[y, x - 1] != 0)
                    {
                        direction = 4;
                    }
                }
                else if (direction == 4)
                {
                    if (y == 0)
                    {
                        direction = 1;
                    }
                    else if (answer[y - 1, x] != 0)
                    {
                        direction = 1;
                    }
                }

                switch (direction)
                {
                    case 1:
                        x++;
                        break;
                    case 2:
                        y++;
                        break;
                    case 3:
                        x--;
                        break;
                    case 4:
                        y--;
                        break;
                }
            }

            return answer;
        }

        public static void main(string[] args)
        {
            Solution s = new Solution();

            Console.WriteLine(String.Join(" ",s.solution(30)));
        }
    }



}
