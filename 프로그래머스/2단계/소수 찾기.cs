using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.소수_찾기2
{
    class Solution
    {
        public bool CheckPrimNum(int num)
        {
            if (num == 0 || num==1)
                return false;

            int divisor = (int)Math.Sqrt(num)+1;
            for(int i=2; i<divisor; i++)
                if (num % i == 0)
                    return false;

            return true;
        }
        public void AddCase(int currentNum, List<int> arr, ref SortedSet<int> caseSet)
        {
            //Console.WriteLine($"currentNum: {currentNum}");
            if (arr.Count == 0)
            {
                caseSet.Add(currentNum);
                //Console.WriteLine($"caseSet에 {currentNum} 추가함");
                return;
            }

            for(int i=0; i <=arr.Count; i++)
            {
                if(i!=arr.Count)
                {
                    var list = arr.ConvertAll(x => x);
                    var newNum = currentNum * 10 + list[i];
                    list.RemoveAt(i);

                    AddCase(newNum, list, ref caseSet);
                }
                else
                {
                    caseSet.Add(currentNum);
                    //Console.WriteLine($"caseSet에 {currentNum} 추가함");
                }
            }
        }
        public int solution(string numbers)
        {
            int[] arr = new int[numbers.Length];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = numbers[i] - '0';

            SortedSet<int> set = new SortedSet<int>();
            for(int i=0; i<numbers.Length; i++)
                AddCase(0, arr.ToList(), ref set);

            var setList = set.ToList();
            int count = 0;
            for(int i=0; i< setList.Count; i++)
            {
                if (CheckPrimNum(setList[i]))
                    count++;
            }

            return count;
        }

        public static void main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine(solution.solution("17"));
        }
    }
}
