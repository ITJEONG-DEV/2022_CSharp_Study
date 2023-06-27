using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로그래머스.개인정보_수집_유효기간
{
    public class Solution
    {
        public int[] solution(string today, string[] terms, string[] privacies)
        {
            List<int> result = new List<int>();

            Dictionary<string, int> privacy_period = new Dictionary<string, int>();

            foreach (string term in terms)
            {
                var data = term.Split(' ');

                privacy_period[data[0]] = int.Parse(data[1]);
            }

            for (int i = 0; i < privacies.Length; i++)
            {
                string privacy = privacies[i];

                string[] data = privacy.Split(' ');
                string[] start_date = data[0].Split('.');

                int year = int.Parse(start_date[0]);
                int month = int.Parse(start_date[1]);
                int day = int.Parse(start_date[2]);

                int term = privacy_period[data[1]];

                month += term;
                day -= 1;

                if (day < 1)
                {
                    month -= 1;
                    day = 28;
                }

                if (month > 12)
                {
                    year += month / 12;
                    month -= month / 12 * 12;

                    if (month == 0)
                    {
                        year -= 1;
                        month = 12;
                    }
                }

                string date = $"{year:D4}.{month:D2}.{day:D2}";

                if (date.CompareTo(today) < 0)
                {
                    result.Add(i + 1);
                }

            }

            return result.ToArray();
        }
    }
}
