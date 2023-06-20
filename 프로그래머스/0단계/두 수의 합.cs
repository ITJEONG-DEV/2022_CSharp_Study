using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.두_수의_합
{
    public class Solution
    {
        public string solution(string a, string b)
        {

            int aPointer = a.Length - 1;
            int bPointer = b.Length - 1;

            int max = aPointer > bPointer ? aPointer : bPointer;

            int roundup = 0;

            StringBuilder str = new StringBuilder();
            for (int i = 0; i <=max; i++)
            {
                int sum = 0;

                if(aPointer < 0)
                {
                    sum = (b[bPointer] - '0') + roundup;
                }
                else if(bPointer < 0)
                {
                    sum = (a[aPointer] - '0') + roundup;

                }
                else
                {
                    sum = (a[aPointer] - '0') + (b[bPointer] - '0') + roundup;
                }

                if (sum > 9)
                {
                    roundup = 1;
                    sum -= 10;
                }
                else
                {
                    roundup = 0;
                }

                str.Insert(0, sum);

                aPointer--;
                bPointer--;
            }

            if(roundup == 1)
            {
                str.Insert(0, 1);
            }

            if (str.Length == 0)
                return "0";

            return str.ToString();
        }
    }
}
