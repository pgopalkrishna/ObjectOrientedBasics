using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedBasics
{
    public class CollectionsAssignment
    {
        //public static void Main(string[] args)
        //{
        //    //create15 students
        //    var Studs = Student.GetStudents(15);
        //    Studs.ForEach(s => Student.Print(s));
        //    var StudentsByDivisions=Studs.GroupBy(d =>d.CurrentDivision).Select(group=>group.ToList()).ToList();
        //    Console.WriteLine("===================================");
        //    StudentsByDivisions.ForEach(s => Student.PrintStudentByDivision(s));
        //    Console.WriteLine("===================================");
        //    //Console.WriteLine("shuffled divisionswithout changing division values of students=>");
        //    //var ShuffledWithoutDivision= Student.ShuffleStudentsWithoutDivision(StudentsByDivisions);
        //    //ShuffledWithoutDivision.ForEach(s => Student.PrintStudentByDivision(s));
        //    Console.WriteLine("===================================");
        //    Console.WriteLine("shuffled divisions of students=>");
        //    Student.ShuffleStudentsByDivision(Studs);
        //    StudentsByDivisions.ForEach(s => Student.PrintStudentByDivision(s));
        //    Console.ReadLine();
        //}
    }
    //public class Student
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int CurrentDivision { get; set; }

    //    public static void Print(Student student)
    //    {
    //        Console.WriteLine("Student=>Id={0},Name={1},Division={2}", student.Id, student.Name, Division.GetDivisions(3).Find(d => d.Id == student.CurrentDivision).Name);
    //        Console.WriteLine("-----------------------------------------------");
    //    }
    //    public static void PrintStudentByDivision(List<Student> studs)
    //    {
    //        Console.WriteLine("Division:{0}=>", Division.GetDivisions(3).Find(d => d.Id == studs[0].CurrentDivision).Name);
    //        studs.ForEach(s => Student.Print(s));
    //        Console.WriteLine("===================================");
    //    }
    //    public static List<Student> ShuffleStudentsByDivision(List<Student> studs)
    //    {
    //        foreach (var stud in studs) {
    //            switch (stud.CurrentDivision) {
    //                case 1:
    //                    stud.CurrentDivision = 2;
    //                    break;
    //                case 2:
    //                    stud.CurrentDivision = 3;
    //                    break;
    //                case 3:
    //                    stud.CurrentDivision = 1;
    //                    break;
    //            }
    //        }
    //        return studs;
    //    }
    //    public static List<List<Student>> ShuffleStudentsWithoutDivision(List<List<Student>> studs)
    //    {
    //        var temp = studs[2];
    //        studs[2] = studs[1];
    //        studs[1] = studs[0];
    //        studs[0] = temp;
    //        return studs;
    //    }
    //    public static List<Student> GetStudents(int numberOfStudents)
    //    {
    //        var Studs = new List<Student>();
    //        var divisions = Division.GetDivisions(3);
    //        int DivisionCount = 0;
    //        for (int i = 0; i < numberOfStudents; i++)
    //        {
    //            if (DivisionCount > 2)
    //                DivisionCount = 0;
    //            Studs.Add(new Student() { Id = i + 1, Name = $"Student_{i + 1}", CurrentDivision = divisions[DivisionCount].Id });
    //            DivisionCount++;
    //        }
    //        return Studs;
    //    }
    //}//student
 
    //public class Division
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public static List<Division> GetDivisions(int numberOfDivisions)
    //    {
    //        var divisions = new List<Division>();
    //        //{
    //        //    new Division{ Id= 1,Name= "A"},new Division{ Id= 1,Name= "B"},new Division{ Id= 1,Name= "C"}
    //        //};
    //        for (int i = 0; i < numberOfDivisions; i++) 
    //        {
    //            divisions.Add(new Division() { Id = i + 1, Name = $"Division_{i + 1}" });
    //        }
    //        return divisions;
    //    }
    //}//division
}//namespace
