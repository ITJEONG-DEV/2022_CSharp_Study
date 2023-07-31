using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.전력망을_둘로_나누기
{
    public class Solution
    {
        public class Node
        {
            public int n;
            List<int> connection;

            public Node(int n)
            {
                this.n = n;
                this.connection = new List<int>();
            }
            public void AddConnection(int n)
            {
                if(!connection.Contains(n))
                    connection.Add(n);
            }
            public int GetNumofConnection()
            {
                return connection.Count;
            }
            public List<int> GetConnection()
            {
                return connection;
            }
        }
        public int CheckDiffer(Node node, int exception, ref Dictionary<int, Node> treeMap, int n)
        {
            List<int> left = new List<int>();
            Queue<int> queue = new Queue<int>();

            Node cur = node;

            while(true)
            {
                if(!left.Contains(cur.n))
                {
                    left.Add(cur.n);
                    Console.WriteLine($"left.Add({cur.n})");
                }

                foreach (var connection in cur.GetConnection())
                {
                    if (cur.n == node.n && connection == exception) continue;

                    if(!left.Contains(connection) && !queue.Contains(connection))
                    {
                        Console.WriteLine($"Check Connection: {cur.n} - {connection}");
                        queue.Enqueue(connection);
                    }
                }

                if (queue.Count == 0) break;

                cur = treeMap[queue.Dequeue()];
            }

            return Math.Abs(2 * left.Count - n);
        }
        public int solution(int n, int[,] wires)
        {
            if (n == 2) return 0;
            if (n == 3) return 1;

            Dictionary<int, Node> treeMap = new Dictionary<int, Node>();

            for(int i=0; i<wires.GetLength(0); i++)
            {
                if (!treeMap.ContainsKey(wires[i, 0]))
                    treeMap[wires[i, 0]] = new Node(wires[i, 0]);

                treeMap[wires[i, 0]].AddConnection(wires[i, 1]);

                if (!treeMap.ContainsKey(wires[i, 1]))
                    treeMap[wires[i, 1]] = new Node(wires[i, 1]);

                treeMap[wires[i, 1]].AddConnection(wires[i, 0]);
            }

            List<Node> candidates = new List<Node>();
            int result = n;
            foreach(var key in treeMap.Keys)
            {
                if (treeMap[key].GetNumofConnection() > 1)
                {
                    foreach(var connection in treeMap[key].GetConnection())
                    {
                        int r = CheckDiffer(treeMap[key], connection, ref treeMap, n);

                        if (result > r)
                            result = r;

                        if (n % 2 == 1 && result == 1) return result;
                        if (n % 2 == 0 && result == 0) return result;
                    }
                }
            }

            return result;
        }
    }
}
