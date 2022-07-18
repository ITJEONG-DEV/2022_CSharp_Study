using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Linq
{
    class LinqExample
    {
        static void main(string[] args)
        {
            //    int[] numbers = { 2, 4, 6, 1, 3, 7, 8, 9, 10, 5 };

            //    var query = from num in numbers
            //                where num % 2 == 1
            //                orderby num ascending
            //                select num;

            //    foreach (int n in query)
            //    {
            //        string msg = string.Format("홀수 : {0}", n);
            //        Console.WriteLine(msg);
            //    }

            //List<Student> _list = new List<Student>();

            //for(int idx =0; idx<10; idx++)
            //{
            //    Student stu = new Student();
            //    stu.Name = "학생_" + idx;
            //    stu.Age = 20;
            //    stu.Grade = "2학년";
            //    stu.Score = 90 + idx;

            //    _list.Add(stu);
            //}

            //var query = from stu in _list
            //            where stu.Score >= 95
            //            orderby stu.Score ascending
            //            select new
            //            {
            //                Name = stu.Name,
            //                Score = stu.Score
            //            };

            //foreach(var stu in query)
            //{
            //    string msg = string.Format("{0} : {1}", stu.Name, stu.Score);
            //    Console.WriteLine(msg);
            //}

            //School[] _studentArr =
            //{
            //    new School() {_Class = "A반", Scores = new int[] { 51, 45, 75, 95, 62, 75 } },
            //    new School() {_Class = "B반", Scores = new int[] { 21, 65, 72, 15, 62, 75 }},
            //    new School() {_Class = "C반", Scores = new int[] { 41, 85, 73, 25, 42, 85 }},
            //    new School() {_Class = "D반", Scores = new int[] { 71, 75, 74, 35, 52, 75 }},
            //    new School() {_Class = "E반", Scores = new int[] { 81, 25, 75, 45, 22, 65 }},
            //    new School() {_Class = "F반", Scores = new int[] { 21, 35, 77, 55, 12, 25 }},
            //    new School() {_Class = "G반", Scores = new int[] { 11, 45, 95, 65, 12, 95 }},
            //};

            //var query = from stu in _studentArr
            //            from sc in stu.Scores
            //            where sc >= 50
            //            orderby sc
            //            select new
            //            {
            //                stu._Class,
            //                Lowest = sc
            //            };

            //foreach(var stu in query)
            //{
            //    string msg = string.Format("name: {0}, score: {1}", stu._Class, stu.Lowest);
            //    Console.WriteLine(msg);
            //}

            Student[] _studentArr =
            {
                new Student() { _Class = "A반", Name = "학생1", Age = 20, Score = 45 },
                new Student() { _Class = "A반", Name = "학생2", Age = 20, Score = 55 },
                new Student() { _Class = "B반", Name = "학생3", Age = 20, Score = 65 },
                new Student() { _Class = "A반", Name = "학생4", Age = 20, Score = 25 },
                new Student() { _Class = "C반", Name = "학생5", Age = 20, Score = 35 },
                new Student() { _Class = "D반", Name = "학생6", Age = 20, Score = 15 },
                new Student() { _Class = "D반", Name = "학생7", Age = 20, Score = 85 },
                new Student() { _Class = "B반", Name = "학생8", Age = 20, Score = 99 },
                new Student() { _Class = "C반", Name = "학생9", Age = 20, Score = 100 },
                new Student() { _Class = "C반", Name = "학생10", Age = 20, Score = 51 }
            };

            var query = from arr in _studentArr
                        orderby arr._Class, arr.Score ascending
                        group arr by arr._Class into g
                        select new
                        {
                            GroupKey = g.Key,
                            Student = g
                        };

            foreach(var Group in query)
            {
                Console.WriteLine($"반 별 그룹: {Group.GroupKey}");

                foreach(var students in Group.Student)
                {
                    Console.WriteLine($"{students.Name}, {students.Score}");
                }
                Console.WriteLine();
            }
        }

    }

    public class Student
    {
        public string _Class { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public int Score { get; set; }
    }

    public class School
    {
        public string _Class { get; set; }
        public int[] Scores { get; set; }
    }
}
