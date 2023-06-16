using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAuto
{
    internal class EmpAuto
    {

        private static int nextEmpNo = 1;
        int EmpNo { get; }
        String Name;
        decimal BasicSalary;
        short DeptNo;

        public EmpAuto() {
            EmpNo = nextEmpNo;
            nextEmpNo++;
            Console.WriteLine("empty cont is called");
            Console.WriteLine("employee no: " + EmpNo + " " + "Name: " + Name + " " + "Department No: " + DeptNo + " " + "salary: " + BasicSalary);
        }

        public EmpAuto(String Name, decimal BasicSalary, short DeptNo)
        {
            EmpNo = nextEmpNo;
            nextEmpNo++;
            this.Name = Name;            
            this.BasicSalary = BasicSalary;
            this.DeptNo = DeptNo;
            Console.WriteLine("cont1 is called");
            Console.WriteLine("employee no: " + EmpNo +" "+ "Name: " + Name + " " + "Department No: " + DeptNo + " " + "salary: " + BasicSalary  );
        }

        public EmpAuto(String Name, decimal BasicSalary)
        {
            EmpNo = nextEmpNo;
            nextEmpNo++;
            this.Name = Name;
            this.BasicSalary = BasicSalary;
         
            Console.WriteLine("cont2 is called");
            Console.WriteLine("employee no: " + EmpNo + " " + "Name: " + Name + " " + "Department No: " + DeptNo + " " + "salary: " + BasicSalary);
        }


        public EmpAuto(String Name)
        {
            EmpNo = nextEmpNo;
            nextEmpNo++;
            this.Name = Name;
            
            Console.WriteLine("cont3 is called");
            Console.WriteLine("employee no: " + EmpNo + " " + "Name: " + Name + " " + "Department No: " + DeptNo + " " + "salary: " + BasicSalary);
        }

      


    }
}
