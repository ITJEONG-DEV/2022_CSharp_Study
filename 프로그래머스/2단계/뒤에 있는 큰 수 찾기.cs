using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.뒤에_있는_큰_수_찾기
{
    public class Solution
    {
        public int[] solution(int[] numbers)
        {
            int[] result = new int[numbers.Length];

            Stack<int> stack = new Stack<int>();

            stack.Push(numbers[numbers.Length - 1]);
            result[numbers.Length - 1] = -1;

            for (int i = numbers.Length - 2; i >= 0; i--)
            {
                if(stack.Count == 0)
                {
                    result[i] = -1;
                    stack.Push(numbers[i]);
                }
                else
                {
                    int peek = stack.Peek();
                    int n = numbers[i];
                    if(peek > n)
                    {
                        result[i] = peek;
                        stack.Push(n);
                    }
                    else
                    {
                        result[i] = -1;
                        while(stack.Count >0 && stack.Peek() < n)
                        {
                            stack.Pop();
                        }

                        stack.Push(n);
                    }
                }
            }

            return result;
        }
    }
}
