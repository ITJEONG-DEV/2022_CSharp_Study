using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.조이스틱
{
    class Solution
    {
        // 문자 a에서 문자 b까지 변경하기 위해 필요한 최소 조작 횟수를 반환함
        public int GetMinimumCountOfAlphabetStick(char a, char b)
        {
            if (a == b)
                return 0;

            int[] counts = { 0, 0 };

            counts[0] = Math.Abs(b - a);
            counts[1] = Math.Abs(('Z' - 'A' + 1) - b + a);

            //Console.WriteLine($"alphabet: {a,2}->{b,2}, {counts.Min(),2} || {counts[0],2}, {counts[1],2}");

            return counts.Min();
        }

        // 위치 cursor에서 위치 target까지 이동하기 위해 필요한 최소 조작 횟수
        public int GetMinimumCountOfMovingStick(int cursor, int target, int length)
        {
            if (cursor == target)
                return 0;

            int[] counts = { 0, 0 };

            counts[0] = Math.Abs(target - cursor);
            counts[1] = Math.Abs((length - target) + cursor);

            Console.WriteLine($"moving  : {cursor,2}->{target,2}, {counts.Min(),2} || {counts[0],2}, {counts[1],2}");

            return counts.Min();
        }

        // cursor > target 순방향 이동횟수
        public int GetMinimumCountofMovingStickForward(int cursor, int target, int length)
        {
            if (cursor <= target)
                return Math.Abs(cursor - target);
            else
                return Math.Abs(target + length - cursor);
        }

        // cursor > target 역방향 이동횟수
        public int GetMinimumCountofMovingStickBackward(int cursor, int target, int length)
        {
            if (target <= cursor)
                return Math.Abs(target - cursor);
            else
                return Math.Abs(cursor + length - target);
        }

        // 이동 비용이 가장 적은 순/역방향 조작을 모두 확인하는 재귀 함수
        public int CheckCount(string currentName, int cursor, int currentCost, ref string targetName)
        {
            if (currentName == targetName)
                return currentCost;

            //Console.WriteLine($"\n현재: {currentName}, 목표: {targetName}, 현재 커서={cursor}, 현재 비용={currentCost}");

            // 코스트 계산
            int[] alphabetCost = new int[currentName.Length];
            int[] moveForwardCost = new int[currentName.Length];
            int[] moveBackwardCost = new int[currentName.Length];

            int minTotal = int.MaxValue;
            int minMoveForward = int.MaxValue;
            int minMoveBackward = int.MaxValue;

            for(int i=0; i<alphabetCost.Length; i++)
            {
                if (currentName[i] == targetName[i])
                {
                    alphabetCost[i] = int.MaxValue;
                    moveForwardCost[i] = int.MaxValue;
                    moveBackwardCost[i] = int.MaxValue;
                }
                else
                {
                    alphabetCost[i] = GetMinimumCountOfAlphabetStick(currentName[i], targetName[i]);
                    moveForwardCost[i] = GetMinimumCountofMovingStickForward(cursor, i, alphabetCost.Length);
                    moveBackwardCost[i] = GetMinimumCountofMovingStickBackward(cursor, i, alphabetCost.Length);
                }

                if (alphabetCost[i] < minTotal)
                    minTotal = alphabetCost[i];

                if (moveForwardCost[i] < minMoveForward)
                    minMoveForward = moveForwardCost[i];

                if (moveBackwardCost[i] < minMoveBackward)
                    minMoveBackward = moveBackwardCost[i];
            }

            List<int> final_cost = new List<int>();
            for(int i=0; i<alphabetCost.Length; i++)
            {
                if (moveForwardCost[i] == minMoveForward)
                {
                    string newName = currentName.Substring(0, i) + targetName[i] + currentName.Substring(i + 1);
                    int newCost = currentCost + alphabetCost[i] + moveForwardCost[i];

                    //Console.WriteLine($"조이스틱 조작(Forward): {currentName}->{newName}, cursor={cursor}->{i}, cost={currentCost}->{newCost}");
                    final_cost.Add(CheckCount(newName, i, newCost, ref targetName));
                    //Console.WriteLine();
                }

                if (moveBackwardCost[i] == minMoveBackward)
                {
                    string newName = currentName.Substring(0, i) + targetName[i] + currentName.Substring(i + 1);
                    int newCost = currentCost + alphabetCost[i] + moveBackwardCost[i];

                    //Console.WriteLine($"조이스틱 조작(Backward): {currentName}->{newName}, cursor={cursor}->{i}, cost={currentCost}->{newCost}");
                    final_cost.Add(CheckCount(newName, i, newCost, ref targetName));
                    //Console.WriteLine();
                }
            }

            return final_cost.Min();
        }

        public int solution(string name)
        {
            string startName = "";
            for (int i = 0; i < name.Length; i++)
                startName += "A";

            return CheckCount(startName, 0, 0, ref name);
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();
            
            Console.WriteLine(solution.solution("BBBBAAAABA"));
        }
    }
}
