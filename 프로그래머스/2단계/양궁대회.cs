using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.양궁대회
{
    public class Solution
    {
        public bool GetLowScoreDistribution(ref int[] a, ref int[] b)
        {
            for(int i=10; i>=0; i--)
            {
                if (a[i] > b[i])
                    return true;
            }

            return false;
        }
        public int GetScoreDifference(ref int[] rion, ref int[] appeach)
        {
            int rScore = 0;
            int aScore = 0;
            for(int i=0; i<11; i++)
            {
                if (rion[i] <= appeach[i])
                    aScore += 10 - i;
                else
                    rScore += 10 - i;
            }

            return rScore - aScore;
        }
        public int[] FindResult(int[] rion, int currentN, int n, int currentIndex, int maxIndex, ref int[] appeach)
        {
            if (currentN == n)
            {
                return rion;
            }
            if(currentIndex == -1)
            {
                rion[10] += n - currentN;
                return rion;
            }

            int[] result1 = null;
            int[] result2 = null;

            int appeachScore = appeach[currentIndex];

            if(currentN + appeachScore + 1 <= n)
            {
                int[] newRion = (int[])rion.Clone();
                newRion[currentIndex] = appeachScore + 1;

                int newN = currentN + appeachScore + 1;

                result1 = FindResult(newRion, newN, n, currentIndex - 1, maxIndex, ref appeach);
            }

            result2 = FindResult(rion, currentN, n, currentIndex - 1, maxIndex, ref appeach);

            if (result1 == null && result2 == null) return null;
            else if (result1 == null) return result2;
            else if (result2 == null) return result1;
            else
            {
                int s1 = GetScoreDifference(ref result1, ref appeach);
                int s2 = GetScoreDifference(ref result2, ref appeach);

                if(s1 == s2)
                    return GetLowScoreDistribution(ref result1, ref result2) ? result1: result2;
                else return s1 > s2 ? result1 : result2;
            }
        }
        public int[] solution(int n, int[] info)
        {
            int[] rion = new int[11];
            var result = FindResult(rion, 0, n, 10, 10, ref info);

            int scoreDifference = GetScoreDifference(ref result, ref info);

            return scoreDifference <= 0 ? new int[] {-1} : result;
        }
    }
}
