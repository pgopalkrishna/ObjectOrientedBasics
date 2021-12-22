using System;
using System.Collections.Generic;
using System.Linq;
namespace ObjectOrientedBasics.LinqBasics
{
    class LinqBasics
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>()
            {
                new Course(){ Id=1,Name="Course1"},
                new Course(){ Id=2,Name="Course2"},
                new Course(){ Id=3,Name="Course3"},
            };
            IList<Student> studentList = new List<Student>() {
                                                            new Student() { StudentID = 1, StudentName = "John", Age = 18 ,CourseId=1} ,
                                                            new Student() { StudentID = 2, StudentName = "Steve",  Age = 15,CourseId=1 } ,
                                                            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 ,CourseId=2} ,
                                                            new Student() { StudentID = 4, StudentName = "Robert" , Age = 20,CourseId=2 } ,
                                                            new Student() { StudentID = 5, StudentName = "Jessica" , Age = 19,CourseId=3 },
                                                            new Student() { StudentID = 6, StudentName = "Jenny" , Age = 19,CourseId=3 }
                                                            };

            //var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);
            PrintStudent(studentList);
            var Students = studentList.Join(courses,
                stud => stud.CourseId,
                c => c.Id,
                (stud, c) => new StudentVM
                {
                    StudentID = stud.StudentID,
                    StudentName = stud.StudentName,
                    Age = stud.Age,
                    CourseName = c.Name
                }).ToList();
            PrintStudentVM(Students);
            var courseWiseStudents = courses.GroupJoin(studentList, c => c.Id, st => st.CourseId, (c, st) => new { c.Id, st });
            Console.WriteLine("============================================");
            foreach (var key in courseWiseStudents)
            {
                Console.WriteLine($"Student in course {courses.Find(c => c.Id == key.Id).Name}=>");
                PrintStudent(key.st.ToList());
                Console.WriteLine("------------------------------------------");
            }
            Console.WriteLine("============================================");
            Console.WriteLine("Concating");
            var nums1 = new List<int>() { 1, 2, 3, 4, 5 };
            var nums2 = new List<int>() { 6, 7, 8, 9, 10 };
            var r = nums1.Concat(nums2);
            foreach (var n in r)
            {
                Console.WriteLine(n);
            }
            int a = 1, b = 1;
            string aStr = "1", bStr = "1";
            Console.WriteLine($"a==b =>{a == b} |and a.Equals(b)=>{a.Equals(b)}");
            Console.WriteLine($"aStr==bStr =>{aStr == bStr} |and aStr.Equals(bStr)=>{aStr.Equals(bStr)}");
            string str = "hello";
            char[] values = { 'h', 'e', 'l', 'l', 'o' };
            string str2 = new string(values);
            Console.WriteLine($"Using Equality operator '{str}' =='{str2}': {str == str2}");
            Console.WriteLine("Using equals() method : {0}", str.Equals(str2));
        }
        public static void PrintStudent(IList<Student> studentList)
        {
            foreach (var stud in studentList)
            {
                Console.WriteLine($"StudentID = {stud.StudentID}, StudentName = {stud.StudentName}, Age = {stud.Age} ,CourseId={stud.CourseId}");
            }
        }
        public static void PrintStudentVM(IList<StudentVM> studentListVM)
        {
            foreach (var stud in studentListVM)
            {
                Console.WriteLine($"{stud.StudentName}");
            }
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int CourseId { get; set; }
    }
    public class StudentVM
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string CourseName { get; set; }
    }
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
