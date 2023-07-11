using System;

namespace 백준.Silver.너의_평점은
{
    class Solution
    {
        public static double GetScore(string grade)
        {
            switch (grade)
            {
                case "A+":
                    return 4.5;
                case "A0":
                    return 4.0;
                case "B+":
                    return 3.5;
                case "B0":
                    return 3.0;
                case "C+":
                    return 2.5;
                case "C0":
                    return 2.0;
                case "D+":
                    return 1.5;
                case "D0":
                    return 1.0;
                default:
                    return 0;
            }
        }
        static void main(string[] args)
        {
            double numer = 0;
            double denom = 0;
            for(int i=0; i<20; i++)
            {
                var datas = Console.ReadLine().Trim().Split();

                double score = double.Parse(datas[1]);
                double gradeScore = GetScore(datas[2]);


                if (datas[2] != "P")
                {
                    numer += score * gradeScore;
                    denom += score;
                }
            }

            Console.WriteLine($"{numer / denom}");
        }
    }
}
