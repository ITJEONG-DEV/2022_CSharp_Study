using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.숫자_짝꿍
{
    public class Solution
    {
        public string solution(string X, string Y)
        {
            Dictionary<int, int> x = new Dictionary<int, int>();
            Dictionary<int, int> y = new Dictionary<int, int>();

            List<int> result = new List<int>();

            for(int i=0; i<10; i++)
            {
                x.Add(i, 0);
                y.Add(i, 0);
            }

            for(int i=0; i<X.Length; i++)
            {
                x[X[i] - '0']++;
            }

            for(int i=0; i<Y.Length; i++)
            {
                y[Y[i] - '0']++;
            }

            for(int i=9; i>=0; i--)
            {
                for (int count = 0; count<(x[i] > y[i] ? y[i] : x[i]); count++)
                {
                    result.Add(i);
                }
            }

            if(result.Count == 0)
            {
                return "-1";
            }
            else if (result[0] == 0)
            {
                return "0";
            }

            return String.Join("", result);
        }
    }
}
