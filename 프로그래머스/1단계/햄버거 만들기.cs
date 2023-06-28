using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.햄버거_만들기
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int result = solution.solution(new int[] { 2, 1, 1, 2, 3, 1, 2, 3, 1 });
            Console.WriteLine(result);
        }
        public bool check(ref Stack<int> stack)
        {
            int item1 = stack.Pop();

            if(item1 != 1)
            {
                stack.Push(item1);

                return false;
            }

            int item2 = stack.Pop();

            if (item2 != 3)
            {
                stack.Push(item2);
                stack.Push(item1);

                return false;
            }

            int item3 = stack.Pop();

            if (item3 != 2)
            {
                stack.Push(item3);
                stack.Push(item2);
                stack.Push(item1);

                return false;
            }

            int item4 = stack.Pop();

            if (item4 == 1)
            {
                return true;
            }
            else
            {
                stack.Push(item4);
                stack.Push(item3);
                stack.Push(item2);
                stack.Push(item1);

                return false;
            }
        }
        public void print(Stack<int> stack)
        {
            foreach(Object obj in stack)
            {
                Console.Write(obj.ToString() + " ");
            }
            Console.WriteLine();
        }
        public int solution(int[] ingredient)
        {
            Stack<int> stack = new Stack<int>();
            int count = 0;
            foreach(int item in ingredient)
            {
                stack.Push(item);

                if(stack.Count >= 4)
                {
                    print(stack);
                    if (check(ref stack))
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
