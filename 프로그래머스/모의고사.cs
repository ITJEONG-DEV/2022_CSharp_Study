using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.모의고사
{
    class Solution
    {
        const int COUNT = 3;

        public int[] solution1(int[] answers)
        {
            var p1 = new int[] { 1, 2, 3, 4, 5 };
            var p2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            var p3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            var p_answer = new int[]
            {
                answers.Where((n, idx) => n == p1[idx % p1.Count()]).Count(),
                answers.Where((n, idx) => n == p2[idx % p2.Count()]).Count(),
                answers.Where((n, idx) => n == p3[idx % p3.Count()]).Count()
            };

            return p_answer.Select((n, idx) => new { Index = idx + 1, N = n }).Where(t => t.N == p_answer.Max()).Select(t => t.Index).ToArray();
        }
        public int[] solution(int[] answers)
        {
            int[] number_of_answer = new int[3] { 0, 0, 0 };

            for(int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == i % 5 + 1)
                    number_of_answer[0]++;

                {
                    int n = (i - 1) % 2 % 4;

                    if ((i % 2 == 0 && answers[i] == 2) ||
                        (i % 2 == 1 &&
                            (n==0 && answers[i]==1 ||
                             n==1 && answers[i]==3 ||
                             n==2 && answers[i]==4 ||
                             n==3 && answers[i]==5)
                        )
                        )
                        number_of_answer[1]++;
                }

                {
                    int n = (int)(i / 2) % 5;

                    if (n == 0 && answers[i] == 3 || 
                        n == 1 && answers[i] == 1 ||
                        n == 2 && answers[i] == 2 ||
                        n == 3 && answers[i] == 4 ||
                        n == 4 && answers[i] == 5)
                        number_of_answer[2]++;
                }
            }

            int max = int.MinValue;
            for(int i=0; i<COUNT; i++)
                if(max < number_of_answer[i])
                    max = number_of_answer[i];

            List<int> answer_list = new List<int>();
            for (int i = 0; i < COUNT; i++)
                if (number_of_answer[i] == max)
                    answer_list.Add(i+1);

            int[] answer = answer_list.ToArray();

            return answer;
        }
    }
    class SolutionExample
    {

        static void main(string[] args)
        {
            Solution solution = new Solution();

            int[] answers1 = {1, 2, 3, 4, 5};
            int[] answer1 = solution.solution1(answers1);
            foreach (int n in answer1)
                Console.Write(n + " ");
            Console.WriteLine();

            int[] answers2 = { 1, 3, 2, 4, 2 };
            int[] answer2 = solution.solution1(answers2);
            foreach (int n in answer2)
                Console.Write(n + " ");
            Console.WriteLine();
        }
    }
}
