using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.택배_배달과_수거하기
{

    public class Solution
    {
        public class Solution
        {
            public class Truck
            {
                long distance;
                int position;
                int cap;
                int shipping;
                int collection;

                public Truck(int cap)
                {
                    this.distance = 0;
                    this.position = 0;
                    this.cap = cap;
                    this.shipping = 0;
                    this.collection = 0;
                }

                public int Cap { get { return cap; } }

                public int GetSpare()
                {
                    return cap - shipping - collection;
                }

                public int TakeShippingBox(int n)
                {
                    int spare = GetSpare();

                    if (n <= spare)
                    {
                        this.shipping += n;
                        return 0;
                    }
                    else
                    {
                        this.shipping += spare;
                        return n - spare;
                    }
                }

                public void ShippingSuccess()
                {
                    this.shipping = 0;
                }
                public int TakeCollectionBox(int n)
                {
                    int spare = GetSpare();

                    if (n <= spare)
                    {
                        this.collection += n;
                        return 0;
                    }
                    else
                    {
                        this.collection += spare;
                        return n - spare;
                    }
                }

                public void CollectionSuccess()
                {
                    this.collection = 0;
                }
                public void MoveTo(int position)
                {
                    if (this.position == position) return;

                    this.distance += Math.Abs(position - this.position);
                    this.position = position;
                }

                public long GetDistance()
                {
                    return distance;
                }
            }

            public int GetLastIndex(int start, ref int[] arr)
            {
                for (int i = start; i >= 0; i--)
                    if (arr[i] != 0)
                        return i;

                return -1;
            }

            public long solution(int cap, int n, int[] deliveries, int[] pickups)
            {
                Truck truck = new Truck(cap);

                int d_index = n - 1, p_index = n - 1;
                while (d_index >= 0 || p_index >= 0)
                {
                    // delivery
                    if (d_index != -1)
                    {
                        List<int> d_index_list = new List<int>();
                        while (truck.GetSpare() > 0)
                        {
                            d_index = GetLastIndex(d_index, ref deliveries);
                            if (d_index == -1) break;

                            d_index_list.Add(d_index);

                            int remain = truck.TakeShippingBox(deliveries[d_index]);
                            deliveries[d_index] = remain;
                        }

                        if (d_index_list.Count > 0)
                        {
                            truck.MoveTo(d_index_list[0] + 1);
                            truck.ShippingSuccess();
                        }
                    }

                    // pick ups
                    if (p_index != -1)
                    {
                        List<int> p_index_list = new List<int>();
                        while (truck.GetSpare() > 0)
                        {
                            p_index = GetLastIndex(p_index, ref pickups);
                            if (p_index == -1) break;
                            p_index_list.Add(p_index);

                            int remain = truck.TakeCollectionBox(pickups[p_index]);
                            truck.MoveTo(p_index + 1);
                            pickups[p_index] = remain;


                        }

                        truck.CollectionSuccess();

                    }

                    truck.MoveTo(0);
                }

                return truck.GetDistance();
            }
        }
    }
}