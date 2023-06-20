using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.로그인_성공
{
    public class Solution
    {
        public string solution(string[] id_pw, string[,] db)
        {
            for (int i = 0; i < db.GetLength(0); i++)
            {
                if (id_pw[0] == db[i, 0])
                {
                    if (id_pw[1] == db[i, 1])
                    {
                        return "login";
                    }
                    else
                    {
                        return "wrong pw";
                    }
                }
            }

            return "fail";
        }
    }
}
