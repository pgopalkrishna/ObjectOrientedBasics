using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedBasics
{
    public class CollectionsAssignment2
    {
        public static void Main(string[] args)
        {
            #region List
            //List
            Console.WriteLine("Operation with List=>\n");
            var Studs = Student.GetStudents(15);
            Studs.ForEach(s => Student.Print(s));
            var StudentsByDivisions = Studs.GroupBy(d => d.CurrentDivision).Select(group => group.ToList()).ToList();
            Console.WriteLine("===================================");
            StudentsByDivisions.ForEach(s => Student.PrintStudentByDivision(s));
            Console.WriteLine("===================================");
            Console.WriteLine("shuffled divisions of students=>");
            Student.ShuffleStudentsByDivision(Studs);
            StudentsByDivisions.ForEach(s => Student.PrintStudentByDivision(s));
            #endregion
            #region LinkedList
            //LinkedList
            Console.WriteLine("\n Operation with LinkedList=>\n");
            var Studs_LinkedList = Student.GetStudents_LinkedList(15);
            foreach (Student stud_LinkedList in Studs_LinkedList)
            {
                Student.Print(stud_LinkedList);
            }
            var StudentsByDivisions_LinkList = Studs_LinkedList.GroupBy(d => d.CurrentDivision).Select(group => group.ToList()).ToList();
            LinkedList<Student> StudentsByDivisions_LinkedList;
            Console.WriteLine("===================================");
            foreach (var stud in StudentsByDivisions_LinkList)
            {
                var studList = stud;
                StudentsByDivisions_LinkedList = new LinkedList<Student>(studList);
                Student.PrintStudentByDivision_LinkedList(StudentsByDivisions_LinkedList);
            }
            Console.WriteLine("===================================");
            Console.WriteLine("shuffled divisions of students=>");
            Student.ShuffleStudentsByDivision_LinkedList(Studs_LinkedList);
            foreach (var stud in StudentsByDivisions_LinkList)
            {
                var studList = stud;
                StudentsByDivisions_LinkedList = new LinkedList<Student>(studList);
                Student.PrintStudentByDivision_LinkedList(StudentsByDivisions_LinkedList);
            }
            #endregion
            #region ArrayList
            //ArrayList
            Console.WriteLine("\nOperation with ArrayList=>\n");
            var Studs_ArrayList = Student.GetStudents_ArrayList(15);
            //Studs_ArrayList.ForEach(s => Student.Print(s));
            var studsList = new List<Student>();
            foreach (Student stud_ArrayList in Studs_ArrayList)
            {
                Student.Print(stud_ArrayList);
                studsList.Add(stud_ArrayList);
            }
            var StudentsByDivisions_ListOfListOfStudents = studsList.GroupBy(d => d.CurrentDivision).Select(group => group.ToList()).ToList();
            //var s_arrayList = (ArrayList)StudentsByDivisions_ArrayList__ArrayList[0];
            ArrayList StudentsByDivisions_ArrayList=new ArrayList();
            foreach (var studlist in StudentsByDivisions_ListOfListOfStudents)
            {
                StudentsByDivisions_ArrayList.Add(new ArrayList(studlist));
            }
            foreach (ArrayList stud in StudentsByDivisions_ArrayList) {
                Student.PrintStudentByDivision_ArrayList(stud);
            }
            Console.WriteLine("===================================");
            
            //Console.WriteLine("===================================");
            Console.WriteLine("shuffled divisions of students=>");
            foreach (ArrayList stud in StudentsByDivisions_ArrayList)
            {
                Student.ShuffleStudentsByDivision_ArrayList(stud);
            }
            foreach (ArrayList stud in StudentsByDivisions_ArrayList)
            {
                Student.PrintStudentByDivision_ArrayList(stud);
            }
            #endregion
            Console.ReadLine();
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentDivision { get; set; }

        public static void Print(Student student)
        {
            Console.WriteLine("Student=>Id={0},Name={1},Division={2}", student.Id, student.Name, Division.GetDivisions(3).Find(d => d.Id == student.CurrentDivision).Name);
            Console.WriteLine("-----------------------------------------------");
        }
        public static void PrintStudentByDivision(List<Student> studs)
        {
            Console.WriteLine("Division:{0}=>", Division.GetDivisions(3).Find(d => d.Id == studs[0].CurrentDivision).Name);
            studs.ForEach(s => Student.Print(s));
            Console.WriteLine("===================================");
        }
        public static void PrintStudentByDivision_LinkedList(LinkedList<Student> studs)
        {
            Console.WriteLine("Division:{0}=>", Division.GetDivisions(3).Find(d => d.Id == studs.First.Value.CurrentDivision).Name);
            //studs.ForEach(s => Student.Print(s));
            foreach (var stud in studs)
            {
                Student.Print(stud);
            }
            Console.WriteLine("===================================");
        }
        public static void PrintStudentByDivision_ArrayList(ArrayList studs)
        {
            Student firstStudent = (Student)studs[0];
            Console.WriteLine("Division:{0}=>", Division.GetDivisions(3).Find(d => d.Id == firstStudent.CurrentDivision).Name);
            //studs.ForEach(s => Student.Print(s));
            foreach (Student stud in studs)
            {
                Student.Print(stud);
            }
            Console.WriteLine("===================================");
        }
        public static List<Student> ShuffleStudentsByDivision(List<Student> studs)
        {
            foreach (var stud in studs)
            {
                switch (stud.CurrentDivision)
                {
                    case 1:
                        stud.CurrentDivision = 2;
                        break;
                    case 2:
                        stud.CurrentDivision = 3;
                        break;
                    case 3:
                        stud.CurrentDivision = 1;
                        break;
                }
            }
            return studs;
        }
        public static LinkedList<Student> ShuffleStudentsByDivision_LinkedList(LinkedList<Student> studs)
        {
            foreach (var stud in studs)
            {
                switch (stud.CurrentDivision)
                {
                    case 1:
                        stud.CurrentDivision = 2;
                        break;
                    case 2:
                        stud.CurrentDivision = 3;
                        break;
                    case 3:
                        stud.CurrentDivision = 1;
                        break;
                }
            }
            return studs;
        }
        public static ArrayList ShuffleStudentsByDivision_ArrayList(ArrayList studs)
        {
            foreach (Student stud in studs)
            {
                switch (stud.CurrentDivision)
                {
                    case 1:
                        stud.CurrentDivision = 2;
                        break;
                    case 2:
                        stud.CurrentDivision = 3;
                        break;
                    case 3:
                        stud.CurrentDivision = 1;
                        break;
                }
            }
            return studs;
        }
        public static List<Student> GetStudents(int numberOfStudents)
        {

            var Studs=new List<Student>();
            var divisions = Division.GetDivisions(3);
            int DivisionCount = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                if (DivisionCount > 2)
                    DivisionCount = 0;
                Studs.Add(new Student() { Id = i + 1, Name = $"Student_{i + 1}", CurrentDivision = divisions[DivisionCount].Id });
                DivisionCount++;
            }
            return Studs;
        }
        public static LinkedList<Student> GetStudents_LinkedList(int numberOfStudents)
        {

            LinkedList<Student> Studs = new LinkedList<Student>();
            var divisions = Division.GetDivisions(3);
            int DivisionCount = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                if (DivisionCount > 2)
                    DivisionCount = 0;
                Studs.AddLast(new Student() { Id = i + 1, Name = $"Student_{i + 1}", CurrentDivision = divisions[DivisionCount].Id });
                DivisionCount++;
            }
            return Studs;
        }
        public static ArrayList GetStudents_ArrayList(int numberOfStudents)
        {

            ArrayList Studs = new ArrayList();
            var divisions = Division.GetDivisions(3);
            int DivisionCount = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                if (DivisionCount > 2)
                    DivisionCount = 0;
                Studs.Add(new Student() { Id = i + 1, Name = $"Student_{i + 1}", CurrentDivision = divisions[DivisionCount].Id });
                DivisionCount++;
            }
            return Studs;
        }
    }//student

    public class Division
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static List<Division> GetDivisions(int numberOfDivisions)
        {
            var divisions = new List<Division>();
            for (int i = 0; i < numberOfDivisions; i++)
            {
                divisions.Add(new Division() { Id = i + 1, Name = $"Division_{i + 1}" });
            }
            return divisions;
        }
        public static LinkedList<Division> GetDivisions_LinkedList(int numberOfDivisions)
        {
            var divisions = new LinkedList<Division>();
            for (int i = 0; i < numberOfDivisions; i++)
            {
                divisions.AddLast(new Division() { Id = i + 1, Name = $"Division_{i + 1}" });
            }
            return divisions;
        }
        public static ArrayList GetDivisions_ArrayList(int numberOfDivisions)
        {
            var divisions = new ArrayList();
            for (int i = 0; i < numberOfDivisions; i++)
            {
                divisions.Add(new Division() { Id = i + 1, Name = $"Division_{i + 1}" });
            }
            return divisions;
        }
    }//division
}
