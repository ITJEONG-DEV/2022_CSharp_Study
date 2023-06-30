using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.의상
{
    public class Solution
    {
        public int solution(string[,] clothes)
        {
            Dictionary<string, List<string>> category = new Dictionary<string, List<string>>();

            for(int i=0; i<clothes.GetLength(0); i++)
            {
                string cloth = clothes[i, 0];
                string cat = clothes[i, 1];

                if(!category.ContainsKey(cat))
                {
                    category[cat] = new List<string>();
                }

                category[cat].Add(cloth);
            }

            int num = 1;
            foreach(var key in category.Keys)
            {
                num *= (category[key].Count + 1);
            }

            return num - 1;
        }
    }
}
