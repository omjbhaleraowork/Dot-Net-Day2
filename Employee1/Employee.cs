using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
    internal class Employee
    {
        String Name;
        int EmpNo;
        decimal BasicSalary;
        short DeptNo;

      public decimal GetNetSalary()
        {
            Console.WriteLine("Net salary is: ");
            decimal NetSalary = 0;
            NetSalary = BasicSalary - 20000;

            return NetSalary; 
        }

        public Employee(String Name, int EmpNo, decimal BasicSalary, short DeptNo)
        {
            this.Name = Name;
            this.EmpNo = EmpNo; 
            this.BasicSalary = BasicSalary; 
            this.DeptNo = DeptNo;
            Console.WriteLine("cont1 is called");
            Console.WriteLine("Name: " + Name + " " + "Employee No: " + EmpNo + " " + "salary: " + BasicSalary + " " + "department no: " + DeptNo);
        }

        public Employee(String Name, int EmpNo, decimal BasicSalary)
        {
            this.Name = Name;
            this.EmpNo = EmpNo;
            this.BasicSalary = BasicSalary;
            Console.WriteLine("cont2 is called");
            Console.WriteLine("Name: " + Name + " " + "Employee No: " + EmpNo + " " + "salary: " + BasicSalary + " " + "department no: " + DeptNo);
        }



        public Employee(String Name, int EmpNo)
        {
            this.Name = Name;
            this.EmpNo = EmpNo;
            Console.WriteLine("cont3 is called");
            Console.WriteLine("Name: " + Name + " " + "Employee No: " + EmpNo + " " + "salary: " + BasicSalary + " " + "department no: " + DeptNo);
        }

        public Employee(String Name)
        {
            this.Name = Name;
            Console.WriteLine("cont4 is called");
            Console.WriteLine("Name: " + Name + " " + "Employee No: " + EmpNo + " " + "salary: " + BasicSalary + " " + "department no: " + DeptNo);
        }

        public Employee()
        {
            Console.WriteLine("empty const is called");
            Console.WriteLine("Name: " + Name + " " + "Employee No: " + EmpNo + " " + "salary: " + BasicSalary + " " + "department no: " + DeptNo);
        }

       


    }
}
