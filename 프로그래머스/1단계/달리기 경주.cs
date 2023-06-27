using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.달리기_경주
{
    public class Runner
    {
        public string name = "";
        public Runner prev = null;
        public Runner next = null;

        public Runner(string name, Runner prev)
        {
            this.name = name;
            this.prev = prev;
        }

        public void SetNext(Runner next)
        {
            this.next = next;
        }
    }

    public class Solution
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            var result = solution.solution(new string[] { "mumu", "soe", "poe", "kai", "mine" }, new string[] { "kai", "kai", "mine", "mine" });
            Console.WriteLine(String.Join(" ", result));
        }

        public string[] solution(string[] players, string[] callings)
        {
            Dictionary<string, int> playersDict = new Dictionary<string, int>();

            for(int i=0; i<players.Length; i++)
            {
                playersDict[players[i]] = i;
            }

            foreach(string calling in callings)
            {
                string cur = players[playersDict[calling]];
                string prev = players[playersDict[calling]-1];

                players[playersDict[calling] - 1] = cur;
                players[playersDict[calling]] = prev;

                playersDict[cur]--;
                playersDict[prev]++;

            }
            return players;
        }
    }
}
