using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.글자_지우기
{
    public class Solution
    {
        public string solution(string my_string, int[] indices)
        {
            StringBuilder stringBuilder= new StringBuilder(my_string);

            List<int> list = new List<int>(indices);

            list.Sort();
            list.Reverse();

            foreach(int index in list)
            {
                stringBuilder.Remove(index, 1);
            }

            return stringBuilder.ToString();
        }
    }
}
