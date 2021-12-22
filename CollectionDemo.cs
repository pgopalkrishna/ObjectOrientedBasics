using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedBasics
{
    public class CollectionDemo
    {
        //public static void Main(string[] args)
        //{
        //    //Create 10 courses
        //    //Create 5 students and assign them course
        //    //Create 2 batches and compare
        //    int CourseCount = 10;
        //    int StudentsCount = 10;
        //    List<Course> Courses = new List<Course>();
        //    DateTime currentTime = DateTime.UtcNow;
        //    for (int i = 0; i < CourseCount; i++)
        //    {
        //        Course course = new Course()
        //        {
        //            Id = i,
        //            Name = $"Course_{i + 1}"
        //        };
        //        Courses.Add(course);
        //    }
        //    //Courses.ForEach(c => Console.WriteLine(c.Name));
        //    List<Students> Studs = new List<Students>();
        //    for (int i = 0; i < StudentsCount; i++)
        //    {
        //        Students students = new Students()
        //        {
        //            Id = i + 1,
        //            Name = $"Student_{i + 1}",
        //            DOB = currentTime.AddYears(12),
        //            LibraryID = $"ID_1000_{i}",
        //            Courses = Courses,
        //        };
        //        Studs.Add(students);
        //    }
        //    Students s = new Students()
        //    {
        //        Id = StudentsCount++,
        //        Name = $"Test_{StudentsCount++}",
        //        DOB = currentTime.AddYears(12),
        //        LibraryID = $"ID_1000_{StudentsCount++}",
        //        Courses = Courses,
        //    };
        //    Studs.Add(s);
        //    var student = Studs.Where(st => st.Name.Contains("Test_")).FirstOrDefault();
        //    Students.Print(student);
        //    Console.ReadLine();
        //}
    }
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string LibraryID { get; set; }
        public List<Course> Courses { get; set; }

        public static void Print(Students student)
        {
            Console.WriteLine(student.Name);
            Console.WriteLine(student.LibraryID);
            Console.WriteLine(student.Id);
            Console.WriteLine(student.DOB.ToString("dd/MM/yyyy"));
            student.Courses.ForEach(course => Console.WriteLine(course.Name));
        }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
