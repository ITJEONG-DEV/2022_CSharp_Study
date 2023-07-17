using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.택배상자
{
    public class Solution
    {
        public int solution(int[] order)
        {
            Stack<int> main = new Stack<int>();
            for (int i = order.Length; i > 0; i--)
                main.Push(i);

            Stack<int> sub= new Stack<int>();

            bool[] isSub = new bool[order.Length];

            int count = 0;
            for(int i=0; i<order.Length; i++)
            {
                int n = order[i];
                int box = -1;
                
                while (box != n)
                {
                    if (!isSub[n])
                    {
                        if (main.Count == 0) return count;

                        box = main.Pop();

                        if(box == n)
                        {
                            count++;
                            break;
                        }

                        sub.Push(box);
                        isSub[box-1] = true;
                    }
                    else
                    {
                        if (sub.Count == 0) return count;

                        box = sub.Pop();

                        if (box == n)
                        {
                            count++;
                        }
                        else return count;
                    }
                }
            }

            return count;
        }
    }
}
