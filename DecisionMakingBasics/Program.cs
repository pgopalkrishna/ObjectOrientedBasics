using System;
using System.Collections.Generic;
namespace DecisionMakingBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var StudNames = new string[] { "John", "Dvid", "Mark", "Peter", "Tim", "Chris", "Anna", "Alice", "Jenifer", "Kathrin" };
            Random rnd_grades = new Random();
            List<Student> StudList = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                StudList.Add(new Student
                {
                    Id = i + 1,
                    Name = StudNames[i],
                    History = rnd_grades.Next(0, 100),
                    Maths = rnd_grades.Next(0, 100),
                    Science = rnd_grades.Next(0, 100)
                });
            }
            var PassCount = 0;
            foreach (var stud in StudList)
            {
                var result = GetResult(stud) ? "Pass" : "Fail";
                switch (result)
                {
                    case "Pass":
                        PassCount++;
                        break;
                    case "Fail":
                        break;
                }
                Console.WriteLine("Student {0} is - {1} with aggregate :{2} ", stud.Name, result, GetAggregate(stud));
                Console.WriteLine("Grades: History= {0},Maths= {1},Science={2}", stud.History, stud.Maths, stud.Science);
                Console.WriteLine("==================================");
            }
            Console.WriteLine("Total {0} students Passed out of 10", PassCount);
            Console.WriteLine("***************************");
            Console.ReadLine();
        }
        public static bool GetResult(Student s)
        {
            var result = true;
            if (s.History >= 40F)
            {
                result = true;
                if (s.Maths >= 40F)
                {
                    result = true;
                    result = (s.Science > 40F) ? true : false;
                }
                else { result = false; }
            }
            else
            {
                result = false;
            }
            return result;
        }
        public static float GetAggregate(Student s)
        {
            return (s.History + s.Maths + s.Science) / 3;
        }
    }
    public class Student : Grades
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Grades
    {
        public float History { get; set; }
        public float Maths { get; set; }
        public float Science { get; set; }
    }
}
