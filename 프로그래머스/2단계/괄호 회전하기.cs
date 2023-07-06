using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.괄호_회전하기
{
    public class Solution
    {
        public bool IsPair(char a, char b)
        {
            if (a == '[' && b == ']') return true;
            if (a == '{' && b == '}') return true;
            if (a == '(' && b == ')') return true;

            return false;
        }
        public bool IsStart(char c)
        {
            if (c == '(' || c == '{' || c == '[') return true;
            return false;
        }
        public int solution(string s)
        {
            // 괄호 쌍의 개수가 동일한지 확인
            Dictionary<char, int> numDict = new Dictionary<char, int>();
            numDict['['] = 0;
            numDict[']'] = 0;
            numDict['('] = 0;
            numDict[')'] = 0;
            numDict['{'] = 0;
            numDict['}'] = 0;

            for (int i = 0; i < s.Length; i++)
                numDict[s[i]]++;

            if (numDict['['] != numDict[']'] || numDict['('] != numDict[')'] || numDict['{'] != numDict['}']) return 0;

            // 문자를 하나식 shift하며 괄호쌍 확인
            int count = 0;
            for (int x = 0; x < s.Length; x++)
            {
                if (!IsStart(s[x])) continue;
                if (IsStart(s[(x + s.Length - 1) % s.Length])) continue;

                Stack<char> stack = new Stack<char>();
                bool error = false;

                for (int i = 0; i < s.Length; i++)
                {
                    int index = (x + i) % s.Length;
                    char item = s[index];

                    if (stack.Count > 0)
                    {
                        char peek = stack.Peek();

                        if (IsPair(peek, item))
                        {
                            stack.Pop();
                        }
                        else if (!IsStart(peek) && IsStart(item))
                            error = true;
                        else stack.Push(item);
                    }
                    else
                    {
                        if (stack.Count == 0 && !IsStart(item))
                            error = true;
                        else stack.Push(item);
                    }

                    if (error) break;
                }

                if (stack.Count == 0 && !error) count++;
            }

            return count;
        }
    }
}
