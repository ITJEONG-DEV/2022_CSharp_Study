using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.이진수_더하기
{
    public class Solution
    {
        public string solution(string bin1, string bin2)
        {
            int pointer1 = bin1.Length - 1;
            int pointer2 = bin2.Length - 1;
            int length = pointer1>pointer2 ? pointer1 : pointer2;

            StringBuilder stringBuilder= new StringBuilder();

            bool upper = false;

            for(int i=length; i>=0; i--)
            {
                int sum = (pointer1>= 0 ? (bin1[pointer1] - '0') : 0) + (pointer2>= 0 ? (bin2[pointer2] - '0') : 0) + (upper ? 1 : 0);

                switch (sum)
                {
                    case 3:
                    case 2:
                        upper = true;
                        stringBuilder.Insert(0, sum-2);
                        break;
                    case 0:
                    case 1:
                        upper = false;
                        stringBuilder.Insert(0, sum);
                        break;
                }

                pointer1--;
                pointer2--;
            }

            if(upper)
            {
                stringBuilder.Insert(0, 1);
            }

            return stringBuilder.ToString();
        }
    }
}
