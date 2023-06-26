using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.한_번만_등장한_문자
{
    public class Solution
    {
        public string solution(string s)
        {
            var items = s.GroupBy(x => x)
                .Where(g => g.Count() == 1)
                .Select(y => y.Key)
                .ToList();

            items.Sort();

            return String.Join("", items);
        }
    }
}
