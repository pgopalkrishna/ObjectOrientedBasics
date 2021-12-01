using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Company object*******");
            Company ix = new Company();
            Console.WriteLine("*************Department Object************");
            Department Development = new Department();
            Console.WriteLine("*************Company object with Employee reference ********");
            Company ix1 = new Employee();
            Console.WriteLine("************* Employee Object ***********");
            Employee gk = new Employee();
            Console.WriteLine("Employee Salary : "+ gk.GetEmployeeSalary().ToString());
            gk.EmpId = 1;
            gk.EmpName = "gk";
            gk.DeptId = 2;
            gk.ShowEmpDetails();
            Console.ReadLine();
        }
    }
   

    public class Company {
        public Company() {
            Console.WriteLine("This is Company constuctor");
        }
        public string Name { get; set; }
        public string OfficeAddress { get; set; }
        
    }
    public class Department:Company {
        public Department() {
            Console.WriteLine("This is Department constuctor");
        }
        public int Id { get; set; }
        public string DeptName { get; set; }
    }

    public class Employee : Department {
        public Employee() {
            Console.WriteLine("This is Employee constuctor");
        }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int DeptId { get; set; }
        private double Salary { get; set; }
        public double GetEmployeeSalary()
        {
            this.Salary = 40000;
            return Salary;
        }
        public void ShowEmpDetails() {
            Console.WriteLine("EmpId :{0},EmpName :{1},DeptId :{2},Salary : {3}", EmpId, EmpName, DeptId, this.GetEmployeeSalary());
        }
    } 
}
