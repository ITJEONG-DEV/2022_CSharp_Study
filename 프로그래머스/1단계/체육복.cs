using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.체육복
{
    class Solution
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            int[] list = new int[n];
            for (int i = 0; i < n; i++)
                list[i] = 1;

            // lost
            foreach (int i in lost)
                list[i-1] = 0;

            // reserve
            foreach (int i in reserve)
                list[i-1]++;

            int firstIndex = 0, lastIndex = n - 1;
            while(firstIndex <= lastIndex)
            {
                if (list[firstIndex] != 0)
                {
                    firstIndex++;
                    continue;
                }
                else if (list[lastIndex] != 0)
                {
                    lastIndex--;
                    continue;
                }

                if(firstIndex == lastIndex)
                {
                    if (firstIndex > 0 && list[firstIndex - 1] == 2)
                    {
                        list[firstIndex - 1] = 1;
                        list[firstIndex] = 1;
                    }
                    else if (lastIndex < n-1 && list[lastIndex+1] == 2)
                    {
                        list[lastIndex + 1] = 1;
                        list[lastIndex] = 1;
                    }

                    break;
                }

                if (firstIndex > 0 && list[firstIndex - 1] == 2)
                {
                    list[firstIndex - 1] = 1;
                    list[firstIndex] = 1;
                    firstIndex++;
                }
                else if (firstIndex < n - 1 && list[firstIndex + 1] == 2)
                {
                    list[firstIndex + 1] = 1;
                    list[firstIndex] = 1;
                    firstIndex++;
                }
                else
                    firstIndex++;


                if (lastIndex < n - 1 && list[lastIndex + 1] == 2)
                {
                    list[lastIndex + 1] = 1;
                    list[lastIndex] = 1;
                    lastIndex--;
                }
                else if (lastIndex > 0 && list[lastIndex - 1] == 2)
                {
                    list[lastIndex - 1] = 1;
                    list[lastIndex] = 1;
                    lastIndex--;
                }
                else
                    lastIndex--;
            }

            int answer = 0;
            for (int i = 0; i < n; i++)
                if (list[i] > 0)
                    answer++;

            return answer;
        }

        public int solution2(int n, int[] lost, int[] reserve)
        {
            // lost와 reserve를 정렬 후 List<int>로 변환
            var lostList = lost.OrderBy(x => x).ToList();
            var reserveList = reserve.OrderBy(x => x).ToList();

            // lost.item1 == reserve.item2 를 제외함
            var overlapList = new List<int>();
            foreach(var item in lostList)
                if(reserveList.Contains(item))
                    overlapList.Add(item);

            foreach(var item in overlapList)
            {
                lostList.Remove(item);
                reserveList.Remove(item);
            }

            // 체육복이 있는 학생은 전체 - 두고 온 인원으로 시작함
            int answer = n - lostList.Count;


            // 앞 순서는 앞쪽 사람을 먼저 빌려주고,
            // 뒷 순서는 뒤쪽 사람을 먼저 빌려주도록 조건문 사용
            int firstIndex = 0, lastIndex = lostList.Count - 1;
            int firstLost, lastLost;
            while (firstIndex <= lastIndex && reserveList.Count > 0)
            {
                firstLost = lostList[firstIndex];
                lastLost = lostList[lastIndex];

                if (firstLost == lastLost)
                {
                    if (reserveList.Contains(firstLost - 1))
                        answer++;
                    else if (reserveList.Contains(firstLost + 1))
                        answer++;

                    break;
                }
                if (reserveList.Contains(firstLost - 1))
                {
                    reserveList.Remove(firstLost - 1);
                    firstIndex++;
                    answer++;
                }
                else if(reserveList.Contains(firstLost + 1))
                {
                    reserveList.Remove(firstLost + 1);
                    firstIndex++;
                    answer++;
                }
                else
                firstIndex++;

                if (reserveList.Contains(lastLost + 1))
                {
                    reserveList.Remove(lastLost + 1);
                    lastIndex--;
                    answer++;
                }
                else if (reserveList.Contains(lastLost - 1))
                {
                    reserveList.Remove(lastLost - 1);
                    lastIndex--;
                    answer++;
                }
                else
                    lastIndex--;
            }
            return answer;
        }

        public void Print(ref List<int> list)
        {
            foreach (int i in list)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        public void Print(ref int[] list)
        {
            foreach (int i in list)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        public static void main(string[] args)
        {
            Solution solutoin = new Solution();

            int n = 5;
            int[] lost = { 1, 2, 4, 5 };
            int[] reserver = { 2, 3, 4 };
            Console.WriteLine(solutoin.solution(n, lost, reserver));
        }
    }
}
