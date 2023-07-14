using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.디펜스_게임
{
    public class Solution
    {
        public class Heap
        {
            List<int> list;

            public Heap()
            {
                this.list = new List<int>();
            }

            void Swap(int i, int j)
            {
                int k = this.list[i];
                this.list[i] = this.list[j];
                this.list[j] = k;
            }

            public int Count
            {
                get { return this.list.Count - 1; }
            }

            public bool Push(int n)
            {
                if (list.Count == 0)
                {
                    this.list.Add(0);
                    this.list.Add(n);
                }
                else
                {
                    this.list.Add(n);

                    int insert_index = this.list.Count - 1;
                    int parent_index = insert_index / 2;

                    while (insert_index > 1 && parent_index > 0)
                    {
                        if (this.list[insert_index] > this.list[parent_index])
                        {
                            Swap(parent_index, insert_index);
                            insert_index = parent_index;
                            parent_index = insert_index / 2;
                        }
                        else break;

                    }
                }
                return true;
            }

            public int Pop()
            {
                if (this.list.Count == 1) return 0;

                int value = this.list[1];

                this.list[1] = this.list[this.list.Count - 1];
                this.list.RemoveAt(this.list.Count - 1);

                int index = 1;
                int left_index, right_index;

                while (index < this.list.Count)
                {
                    left_index = index * 2;
                    right_index = index * 2 + 1;

                    // only left child
                    if (right_index == this.list.Count)
                    {
                        if (this.list[index] < this.list[left_index])
                        {
                            Swap(index, left_index);
                            index = left_index;
                        }
                        else break;
                    }

                    // have both child
                    else if (right_index < this.list.Count)
                    {
                        // swap with left child
                        if (this.list[right_index] < this.list[left_index] && this.list[index] < this.list[left_index])
                        {
                            Swap(index, left_index);
                            index = left_index;
                        }

                        // swap with right child
                        else if (this.list[left_index] <= this.list[right_index] && this.list[index] < this.list[right_index])
                        {
                            Swap(index, right_index);
                            index = right_index;
                        }

                        else break;
                    }

                    else break;
                }

                return value;
            }

            public string Print()
            {
                return String.Join(" ", this.list);
            }
        }

        public int solution(int n, int k, int[] enemy)
        {
            if (k >= enemy.Length) return enemy.Length;

            Heap ok = new Heap();
            for (int round = 0; round < enemy.Length; round++)
            {
                ok.Push(-enemy[round]);

                if (ok.Count > k)
                    n += ok.Pop();

                if (n < 0)
                    return round;
            }

            return enemy.Length;
        }
    }


}
