using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.주차_요금_계산
{
    public class Solution
    {
        public class Car
        {
            public int Id { get; set; }
            string enteringTime = null;
            string exitingTime = null;
            int ParkingTime = 0;

            public Car(int id)
            {
                this.Id = id;
            }

            public void AddEnteringTime(string time)
            {
                this.enteringTime = time;
            }
            public void AddExitingTime(string time)
            {
                this.exitingTime = time;
                OperateParkingTime();
            }

            public void OperateParkingTime()
            {
                if (this.enteringTime == null) return;

                if (this.exitingTime == null)
                    this.exitingTime = "23:59";

                var entering = enteringTime.Split(':');
                var exiting = exitingTime.Split(':');

                int hourDiffer = int.Parse(exiting[0]) - int.Parse(entering[0]);
                int minuteDiffer = int.Parse(exiting[1]) - int.Parse(entering[1]);

                this.ParkingTime += hourDiffer * 60 + minuteDiffer;

                this.enteringTime = null;
                this.exitingTime = null;
            }

            public int GetParkingTime()
            {
                OperateParkingTime();
                return this.ParkingTime;
            }
        }
        public int[] solution(int[] fees, string[] records)
        {
            SortedDictionary<int, Car> carDict = new SortedDictionary<int, Car>();

            for (int i = 0; i < records.Length; i++)
            {
                var words = records[i].Split();

                var id = int.Parse(words[1]);

                if (!carDict.ContainsKey(id))
                    carDict[id] = new Car(id);

                if (words[2] == "IN")
                    carDict[id].AddEnteringTime(words[0]);
                else
                    carDict[id].AddExitingTime(words[0]);
            }

            List<int> feeList = new List<int>();
            foreach (var key in carDict.Keys)
            {
                Car car = carDict[key];
                int parkingTime = car.GetParkingTime();

                if (parkingTime == 0) continue;

                if (parkingTime <= fees[0])
                {
                    Console.WriteLine($"Car({car.Id}) Time({parkingTime}) Cost({fees[1]})");
                    feeList.Add(fees[1]);
                    continue;
                }

                parkingTime -= fees[0];

                var cost = fees[1] + (int)Math.Ceiling((double)parkingTime / fees[2]) * fees[3];
                feeList.Add(cost);
                Console.WriteLine($"Car({car.Id}) Time({parkingTime + fees[0]}) Cost({cost})");
            }

            return feeList.ToArray();
        }
    }
}
