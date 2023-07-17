using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.연속_부분_수열_합의_개수
{
    public class Solution
    {
        public void CheckSum(int index, int count, int sum, ref int[] elements, ref Dictionary<int, bool> sumDict)
        {
            sumDict[sum] = true;

            if (count == elements.Length)
                return;

            int newIndex = index + 1 == elements.Length ? 0 : index + 1;

            CheckSum(newIndex, count + 1, sum + elements[newIndex], ref elements, ref sumDict);
        }
        public int solution(int[] elements)
        {
            Dictionary<int, bool> sumDict = new Dictionary<int, bool>();

            for (int i = 0; i < elements.Length; i++)
            {
                CheckSum(i, 1, elements[i], ref elements, ref sumDict);
            }


            return sumDict.Count;
        }
    }
}
