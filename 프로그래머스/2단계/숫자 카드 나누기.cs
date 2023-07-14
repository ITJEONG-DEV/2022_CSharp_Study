using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.숫자_카드_나누기
{
    public class Solution
    {
        public int GetGCD(List<int> nums)
        {
            if (nums.Count == 1) return nums[0];

            for (int i = nums[0]; i >= 1; i--)
            {
                bool flag = true;
                for (int j = 0; j < nums.Count; j++)
                {
                    if (nums[j] % i != 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag) return i;
            }

            return 1;
        }
        public int solution(int[] arrayA, int[] arrayB)
        {
            List<int> listA = arrayA.Distinct().ToList();
            listA.Sort();

            int GCDA = GetGCD(listA);

            List<int> listB = arrayB.Distinct().ToList();
            listB.Sort();

            int GCDB = GetGCD(listB);

            for (int i = 0; i < listA.Count; i++)
            {
                if (listA[i] % GCDB == 0)
                {
                    GCDB = 1;
                    break;
                }
            }

            for(int i=0; i<listB.Count; i++)
            {
                if (listB[i] % GCDA == 0)
                {
                    GCDA = 1;
                    break;
                }
            }

            if (GCDA == 1 && GCDB == 1) return 0;
            else if (GCDA == 1)
            {

                return GCDB;
            }
            else if (GCDB == 1)
            {
                return GCDA;
            }
            else return GCDA > GCDB ? GCDA : GCDB;
        }
    }
}
