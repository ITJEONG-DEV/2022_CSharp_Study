using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.타겟_넘버
{
    class Solution
    {
        public int FindTargetNumber(int currentNumber, int currentIndex, ref int[] numbers, int target)
        {
            if(currentIndex < numbers.Length)
                return FindTargetNumber(currentNumber + numbers[currentIndex], currentIndex + 1, ref numbers, target) + FindTargetNumber(currentNumber - numbers[currentIndex], currentIndex + 1, ref numbers, target);

            if (currentNumber == target)
                return 1;
            else
                return 0;
        }

        public int solution(int[] numbers, int target)
        {
            return FindTargetNumber(0, 0, ref numbers, target);
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(new int[] { 1, 1, 1, 1, 1 }, 3));
            Console.WriteLine(solution.solution(new int[] { 4, 1, 2, 1}, 4));
        }
    }
}
