using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.거리두기_확인하기
{
    class Solution
    {
        enum ObjectType
        {
            NONE = 0,
            PERSON = 1,
            TABLE = 2,
            PARTITION = 3
        };

        public int GetManhattanDistance(int r1, int c1, int r2, int c2)
        {
            return Math.Abs(r1 - r2) + Math.Abs(c1 - c2);
        }

        public bool CheckDistancing(int r1, int c1, int r2, int c2, ref int[,] arr)
        {
            int distance = GetManhattanDistance(r1, c1, r2, c2);

            //Console.WriteLine("({0}, {1}), ({2}, {3})의 맨해튼 거리: {4}", r1, c1, r2, c2, distance);

            if(distance > 2)
                return true;

            if (distance == 1)
                return false;

            // 일직선(P X P)으로 앉아 있는 경우 
            if (Math.Abs(r1 - r2) == 2 && arr[(r1 + r2) / 2, c1] == (int)ObjectType.PARTITION)
                return true;
            else if (Math.Abs(c1 - c2) == 2 && arr[r1, (c1 + c2) / 2] == (int)ObjectType.PARTITION)
                return true;

            // 대각선으로 앉아 있는 경우
            else if (arr[r1, c2] == (int)ObjectType.PARTITION && arr[r2, c1] == (int)ObjectType.PARTITION)
                return true;

            return false;
        }

        public int CheckWholeDistancing(ref int[,] arr, ref List<(int, int)> person)
        {
            //Print(ref person);
            for (int i = 0; i < person.Count; i++)
                for (int j = i + 1; j < person.Count; j++)
                    if (!CheckDistancing(person[i].Item1, person[i].Item2, person[j].Item1, person[j].Item2, ref arr))
                        return 0;

            return 1;
        }

        public int[] solution(string[,] places)
        {
            int[] answer = new int[places.GetLength(0)];
            for(int i=0; i<places.GetLength(0); i++)
            {
                int[,] arr = new int[5, 5];
                List<(int, int)> personList = new List<(int, int)>();

                for(int j=0; j<places.GetLength(1); j++)
                {
                    for(int k=0; k < places[i,j].Length; k++)
                    {
                        char s = places[i, j][k];
                        switch(s)
                        {
                            case 'P':
                                arr[j,k] = (int)ObjectType.PERSON;
                                personList.Add((j, k));
                                break;
                            case 'O':
                                arr[j, k] = (int)ObjectType.TABLE;
                                break;
                            case 'X':
                                arr[j, k] = (int)ObjectType.PARTITION;
                                break;
                        }
                    }
                }

                answer[i] = CheckWholeDistancing(ref arr, ref personList);
            }

            return answer;
        }

        void Print(ref List<(int, int)> list)
        {
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine("({0}, {1})", list[i].Item1, list[i].Item2);
        }
        public static void main(string[] args)
        {
            Solution solution = new Solution();

            string[,] places = new string[,]
            {
                {
                    "POOOP",
                    "OXXOX",
                    "OPXPX",
                    "OOXOX",
                    "POXXP"
                },
                {
                    "POOPX",
                    "OXPXP",
                    "PXXXO",
                    "OXXXO",
                    "OOOPP"
                },
                {
                    "PXOPX",
                    "OXOXP",
                    "OXPOX",
                    "OXXOP",
                    "PXPOX"
                },
                {
                    "OOOXX",
                    "XOOOX",
                    "OOOXX",
                    "OXOOX",
                    "OOOOO"
                },
                {
                    "PXPXP",
                    "XPXPX",
                    "PXPXP",
                    "XPXPX",
                    "PXPXP"
                }
            };
            var result = solution.solution(places);

            for (int i = 0; i < result.Length; i++)
                Console.Write(result[i] + " ");
            Console.WriteLine("");
        }
    }
}
