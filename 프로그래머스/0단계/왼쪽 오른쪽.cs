using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.왼쪽_오른쪽
{
    public class Solution
    {
        public enum Result
        {
            Left = 1,
            Right = 2,
            Empty = 0
        }

        // l(-1) empty(0) r(1)
        public Result GetResult(int l, int r, int count)
        {
            if (l == -1 && r == -1) return Result.Empty;
            else if(l == -1)
            {
                if (r == count - 1) return Result.Empty;
                return Result.Right;
            }
            else if(r == -1)
            {
                if (l == 0) return Result.Empty;
                return Result.Left;
            }
            else
            {
                if (l < r) return Result.Left;
                else return Result.Right;
            }
        }
        public string[] solution(string[] str_list)
        {
            List<string> strs = str_list.ToList();

            int l_index = strs.IndexOf("l");
            int r_index = strs.IndexOf("r");

            Result result = GetResult(l_index, r_index, strs.Count);

            switch(result)
            {
                case Result.Empty:
                    return new string[0] { };
                case Result.Left:
                    return strs.GetRange(0, l_index).ToArray();
                case Result.Right:
                    return strs.GetRange(r_index+1, strs.Count-r_index-1).ToArray();
            }

            return new string[0] { };
        }
    }
}
