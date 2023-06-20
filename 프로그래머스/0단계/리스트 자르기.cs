using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.리스트_자르기
{
    public class Solution
    {
        public int[] solution(int n, int[] slicer, int[] num_list)
        {
            List<int> list = new List<int>(num_list);

            switch (n)
            {
                case 1:
                    return list.GetRange(0, slicer[1] + 1).ToArray();
                case 2:
                    return list.GetRange(slicer[0], list.Count - slicer[0]).ToArray();
                case 3:
                    return list.GetRange(slicer[0], slicer[1] - slicer[0] + 1).ToArray();
                case 4:
                    List<int> result = new List<int>();
                    for(int i = slicer[0]; i <= slicer[1]; i += slicer[2])
                    {
                        result.Add(num_list[i]);
                    }
                    return result.ToArray();
            }

            return null;
        }
    }
}
