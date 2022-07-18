using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스
{
    class Solution
    {
        public int getIndex(ref string[] id_list, ref string id)
        {
            for (int i = 0; i < id_list.Length; i++)
                if (id_list[i] == id)
                    return i;

            return -1;
        }

        public int[] solution(string[] id_list, string[] report, int k)
        {
            HashSet<(int, int)> report_set = new HashSet<(int, int)>();
            foreach (string contents in report)
            {
                var content = contents.Split(' ');

                int index1 = getIndex(ref id_list, ref content[0]);
                int index2 = getIndex(ref id_list, ref content[1]);

                report_set.Add((index1, index2));
            }

            List<int> reporter = new List<int>();
            List<int>[] reportee = new List<int>[id_list.Length];
            for (int i = 0; i < id_list.Length; i++)
                reportee[i] = new List<int>();

            foreach ((int, int) t in report_set)
            {
                reporter.Add(t.Item1);
                reportee[t.Item2].Add(t.Item1);
            }

            int[] answer = new int[id_list.Length];

            for (int i = 0; i < id_list.Length; i++)
                if (reportee[i].Count >= k)
                    for(int j=0; j< reportee[i].Count; j++)
                        answer[reportee[i][j]]++;

            return answer;
        }
    }
    class SolutionExample
    {

        static void main(string[] args)
        {
            Solution solution = new Solution();

            string[] id_list1 = { "muzi", "frodo", "apeach", "neo" };
            string[] report1 = { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" };
            int k1 = 2;

            int[] answer1 = solution.solution(id_list1, report1, k1);
            foreach (int n in answer1)
                Console.Write(n + " ");
            Console.WriteLine();

            string[] id_list2 = { "con", "ryan" };
            string[] report2 = { "ryan con", "ryan con", "ryan con", "ryan con" };
            int k2 = 3;

            int[] answer2 = solution.solution(id_list2, report2, k2);
            foreach (int n in answer2)
                Console.Write(n + " ");
            Console.WriteLine();

        }
    }
}
