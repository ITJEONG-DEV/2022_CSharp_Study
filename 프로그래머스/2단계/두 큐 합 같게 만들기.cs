using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace 프로그래머스.두_큐_합_같게_만들기
{
    public class Solution
    {
        public long GetSum(int start, int end, ref int[] queue)
        {
            long sum = 0;
            for(int i=start; i<end; i++)
            {
                sum += queue[i];
            }

            return sum;
        }
        public int solution(int[] queue1, int[] queue2)
        {
            long sum1 = GetSum(0, queue1.Length, ref queue1);
            long sum2 = GetSum(0, queue2.Length, ref queue2);

            if (sum1 == sum2) return 0;
            if ((sum1 + sum2) % 2 == 1) return -1;

            Queue<int> q1 = new Queue<int>(queue1);
            Queue<int> q2 = new Queue<int>(queue2);

            long targetSum = (sum1 + sum2) / 2;

            int count = 0;
            while(sum1 > targetSum)
            {
                int n = q1.Dequeue();
                sum1 -= n;
                q2.Enqueue(n);
                count++;
            }

            if (sum1 == targetSum) return count;

            int loopCount = 0;
            while(sum1 != targetSum)
            {
                if (++loopCount >= (queue1.Length + queue2.Length)*2) return -1;
                if (q1.Count == 0 || q2.Count == 0) return -1;

                if(sum1 > targetSum)
                {
                    int n = q1.Dequeue();
                    sum1 -= n;
                    q2.Enqueue(n);
                    count++;
                }
                else
                {
                    int n = q2.Dequeue();
                    sum1 += n;
                    q1.Enqueue(n);
                    count++;
                }
            }

            return count;
        }
    }
}
