namespace Employee1
{
    internal class EmpMain
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee("om", 101,60000,1);
            Employee emp2 = new Employee("shivam", 102, 70000);
            Employee emp3 = new Employee("manish", 103);
            Employee emp4 = new Employee("satish");
            Employee emp5 = new Employee();

            emp1.GetNetSalary();
            Console.WriteLine(emp1.GetNetSalary());
           // emp1.ToString();    
           // Console.WriteLine(emp1.ToString);

        }

    }
}