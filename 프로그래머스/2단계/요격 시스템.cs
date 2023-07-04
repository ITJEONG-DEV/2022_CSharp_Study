using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.요격_시스템
{
    public class Solution
    {
        public int solution(int[,] targets)
        {
            Dictionary<int, List<int>> sortDict = new Dictionary<int, List<int>>();

            for(int i=0; i<targets.GetLength(0); i++)
            {
                if (!sortDict.ContainsKey(targets[i, 0]))
                    sortDict[targets[i, 0]] = new List<int>();

                sortDict[targets[i, 0]].Add(targets[i, 1]);
            }

            int index = 0;
            for(int i=100000000; i>=0; i--)
            {
                if(sortDict.ContainsKey(i))
                {
                    sortDict[i].Sort();
                    sortDict[i].Reverse();

                    for(int j=0; j < sortDict[i].Count; j++)
                    {
                        targets[index, 0] = i;
                        targets[index, 1] = sortDict[i][j];
                        index++;
                    }
                }
            }

            int[] range = new int[2] { targets[0, 0], targets[0, 1] };
            int count = 1;
            for(int i=1; i<targets.GetLength(0); i++)
            {
                if (targets[i,1] < range[0])
                {
                    count++;
                    range[0] = targets[i, 1];
                }
            }

            return count;
        }
    }
}
