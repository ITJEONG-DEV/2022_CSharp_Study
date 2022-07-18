using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.K번째수
{
    class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.Length/3];

            for(int i=0; i<commands.Length/3; i++)
            {
                var splittedArray = array.Where((n, idx) => idx >= commands[i,0]-1 && idx <= commands[i,1]-1);
                var alignedArray = (from m in splittedArray orderby m ascending select m).ToArray();

                int num = alignedArray[commands[i, 2]-1];

                answer[i] = num;
            }

            return answer;
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();

            int[] array = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

            var answer = solution.solution(array, commands);

            for (int i = 0; i < answer.Length; i++)
                Console.Write(answer[i] + " ");
            Console.WriteLine();
        }
    }
}
