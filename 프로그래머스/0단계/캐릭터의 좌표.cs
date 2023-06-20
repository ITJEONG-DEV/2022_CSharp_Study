using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.캐릭터의_좌표
{
    public class Solution
    {
        public int[] solution(string[] keyinput, int[] board)
        {
            int[] answer = { 0, 0 };

            foreach (var key in keyinput)
            {
                switch (key)
                {
                    case "up":
                        if (answer[1] < (board[1] - 1) / 2)
                            answer[1] += 1;

                        break;

                    case "down":
                        if (answer[1] > -1 * (board[1] - 1) / 2)
                            answer[1] -= 1;

                        break;

                    case "left":
                        if (answer[0] > -1 * (board[0] - 1) / 2)
                            answer[0] -= 1;

                        break;

                    case "right":
                        if (answer[0] < (board[0] - 1) / 2)
                            answer[0] += 1;

                        break;
                }
            }
            return answer;
        }
    }
}
