using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.커피_심부름
{
    public class Solution
    {
        public int solution(string[] order)
        {
            int price = 0;
            foreach (var item in order)
            {
                if (item.Contains("latte"))
                {
                    price += 5000;
                }
                else
                {
                    price += 4500;
                }
            }

            return price;
        }
    }
}
