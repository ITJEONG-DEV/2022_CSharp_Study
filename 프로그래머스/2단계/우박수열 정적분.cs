using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.우박수열_정적분
{
    public class Solution
    {
        public int GetCollatzConjecture(int n)
        {
            if (n % 2 == 0) return n / 2;
            else return n * 3 + 1;
        }
        public double[] solution(int k, int[,] ranges)
        {
            double[] result = new double[ranges.GetLength(0)];

            // 우박수열
            Dictionary<int, double> sectionArea = new Dictionary<int, double>();

            int h = k;
            int preH = 0;
            int index = 0;
            while(h > 1)
            {
                preH = h;
                h = GetCollatzConjecture(preH);

                double area = ((double)h + preH) / 2;
                sectionArea[index++] = area;
            }

            for(int i = 0; i<result.Length; i++)
            {
                int a = 0 + ranges[i, 0];
                int b = index + ranges[i, 1];

                if(a > b)
                {
                    result[i] = -1;
                    continue;
                }

                double area = 0.0;
                for(int n = a; n<b; n++)
                {
                    area += sectionArea[n];
                }

                result[i] = area;
            }

            return result;
        }
    }
}
