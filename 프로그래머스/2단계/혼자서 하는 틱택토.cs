using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.혼자서_하는_틱택토
{
    public class Solution
    {
        public int solution(string[] board)
        {
            int O = 0;
            int X = 0;
            int OBingo = 0;
            int XBingo = 0;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'X')
                        X++;
                    else if (board[i][j] == 'O')
                        O++;
                }
            }

            if (O == 0 && X == 0) return 1;
            if (O > X + 1 || X > O) return 0;

            for (int i = 0; i < board.Length; i++)
            {
                if (board[0][i] == board[1][i] && board[1][i] == board[2][i])
                {
                    if (board[0][i] == 'X')
                        XBingo++;
                    else if (board[0][i] == 'O')
                        OBingo++;
                }

                if (board[i][0] == board[i][1] && board[i][1] == board[i][2])
                {
                    if (board[i][0] == 'X')
                        XBingo++;
                    else if (board[i][0] == 'O')
                        OBingo++;
                }
            }

            if (board[0][2] == board[1][1] && board[1][1] == board[2][0])
            {
                if (board[0][2] == 'X')
                    XBingo++;
                else if (board[0][2] == 'O')
                    OBingo++;
            }

            if (board[0][0] == board[1][1] && board[1][1] == board[2][2])
            {
                if (board[0][0] == 'X')
                    XBingo++;
                else if (board[0][0] == 'O')
                    OBingo++;
            }

            if (OBingo > 0 && XBingo > 0) return 0;
            if (OBingo > 0 && O <= X) return 0;
            if (XBingo > 0 && O != X) return 0;

            return 1;
        }
    }
}
