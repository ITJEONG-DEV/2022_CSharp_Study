using System;

namespace 프로그래머스.두_원_사이의_정수_쌍
{
    public class Solution
    {
        public long solution(int r1, int r2)
        {
            long count = 0;

            for (int i = 0; i < r2; i++)
            {
                long max = (long)Math.Floor(Math.Sqrt((long)(r2 + i) * (long)(r2 - i)));
                if (i < r1)
                {
                    long min = (long)Math.Ceiling(Math.Sqrt((long)(r1 + i) * (long)(r1 - i)));

                    count += (max - min + 1);
                }
                else
                {
                    count += max;
                }
            }

            return count * 4;
        }
    }
}
