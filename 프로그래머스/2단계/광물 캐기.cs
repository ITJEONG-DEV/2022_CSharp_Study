using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.광물_캐기
{
    public class Solution
    {
        public enum Pick
        {
            dia = 0,
            iron = 1,
            stone = 2
        }
        public enum Mineral
        {
            dia = 0,
            iron = 1,
            stone = 2
        }

        public class MineGroup
        {
            public Dictionary<int, int> energy;

            public MineGroup(ref string[] minerals, int start_index, ref int[] picks)
            {
                energy = new Dictionary<int, int>();

                if (picks[0] > 0) energy[0] = 0;
                if (picks[1] > 0) energy[1] = 0;
                if (picks[2] > 0) energy[2] = 0;

                for (int i = start_index; i < (start_index + 5 < minerals.Length ? start_index + 5 : minerals.Length); i++)
                    for (int j = 0; j < 3; j++)
                        if (picks[j] > 0) energy[j] += Solution.GetEnergy(j, minerals[i]);
            }
            public KeyValuePair<int, int> GetMax()
            {
                return energy.Max();
            }
            public KeyValuePair<int, int> GetMin()
            {
                return energy.Min();
            }

            public int GetEnergy(int pick)
            {
                if (energy.ContainsKey(pick)) return energy[pick];
                else return -1;
            }
        }

        public static int GetEnergy(int pick, string mineral)
        {
            if (mineral == "diamond") return GetEnergy((Pick)pick, Mineral.dia);
            else if (mineral == "iron") return GetEnergy((Pick)pick, Mineral.iron);
            else return GetEnergy((Pick)pick, Mineral.stone);
        }

        public static int GetEnergy(Pick pick, Mineral mineral)
        {
            if ((int)pick == (int)mineral) return 1;
            if (pick == Pick.dia) return 1;
            if (mineral == Mineral.stone) return 1;

            if (pick == Pick.iron || mineral == Mineral.iron) return 5;

            return 25;

        }

        public int solution(int[] picks, string[] minerals)
        {

            // 캘 수 있는 광물의 수
            // 곡괭이의 수보다 캘 수 있는 광물이 많은 경우 고려
            int max_index = minerals.Length;
            int sumOfPicks = picks[0] + picks[1] + picks[2];
            if (minerals.Length > sumOfPicks * 5)
                max_index = sumOfPicks * 5;

            // 광물 그룹의 수 (= 필요한 곡괭이의 수)
            int group_length = (int)Math.Ceiling((double)max_index / 5);

            // 캘 수 있는 광물보다 곡괭이가 많은 경우
            // 좋은 곡괭이들 순서로 추려냄
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if (count + picks[i] <= group_length)
                {
                    count += picks[i];
                }
                else if (count + picks[i] > group_length)
                {
                    picks[i] = group_length - count;
                    count = group_length;
                }
                else
                {
                    picks[i] = 0;
                }
            }

            // Console.WriteLine($"picks: {picks[0]} {picks[1]} {picks[2]}");
            // Console.WriteLine($"group: {group_length}");

            List<MineGroup> mineGroups = new List<MineGroup>();
            for (int i = 0; i < group_length; i++)
            {
                MineGroup mineGroup = new MineGroup(ref minerals, i * 5, ref picks);
                mineGroups.Add(mineGroup);

            }

            int current_pick = picks[2] > 0 ? 2 : (picks[1] > 0 ? 1 : 0);

            int energy = 0;

            for (int j = 0; j < group_length; j++)
            {
                int min_value_among_max_value = int.MaxValue;
                int min_index = 0;

                for (int i = 0; i < mineGroups.Count; i++)
                {
                    var max = mineGroups[i].GetEnergy(current_pick);

                    // Console.Write($"[max] group:{i}, value: {max}");

                    if (max < min_value_among_max_value)
                    {
                        min_value_among_max_value = max;
                        min_index = i;
                    }
                }

                mineGroups.RemoveAt(min_index);
                picks[current_pick]--;

                energy += min_value_among_max_value;
                while (current_pick > -1 && picks[current_pick] == 0)
                {
                    current_pick--;
                }
            }

            return energy;
        }
    }
}
