using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.배열의_원소_삭제하기
{
    public class Solution
    {
        public int[] solution(int[] arr, int[] delete_list)
        {
            List<int> list = new List<int>(arr);

            for (int i = 0; i < delete_list.Length; i++)
                list.Remove(delete_list[i]);

            return list.ToArray();
        }
    }
}
