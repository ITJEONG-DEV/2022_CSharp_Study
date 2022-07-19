using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.기능개발
{
    class Solution
    {
        public int[] solution(int[] progresses, int[] speeds)
        {
            var remain = new int[progresses.Length];
            for(int i=0; i<remain.Length; i++)
                remain[i] = (int)Math.Ceiling((double)(100 - progresses[i]) / speeds[i]);

            Print(ref remain);

            List<int> result = new List<int>();

            int count = 1;
            int target = remain[0];
            for(int i=1; i< remain.Length; i++)
            {
                int n = remain[i];

                if(n <= target)
                {
                    count++;
                }
                else
                {
                    result.Add(count);
                    count = 1;

                    target = n;
                }
            }
            result.Add(count);

            return result.ToArray();
        }

        public void Print(ref List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public void Print(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();

            var progresses1 = new int[] { 93, 30, 55 };
            var speeds1 = new int[] { 1, 30, 5 };

            var progresses2 = new int[] { 95, 90, 99, 99, 80, 99 };
            var speeds2 = new int[] { 1, 1, 1, 1, 1, 1 };

            var progresses3 = new int[] { 40, 93, 30, 55, 60, 65};
            var speeds3 = new int[] {60, 1, 30, 5, 10, 7};

            var result = solution.solution(progresses3, speeds3);

            for (int i = 0; i < result.Length; i++)
                Console.Write(result[i] + " ");
        }
    }
}
