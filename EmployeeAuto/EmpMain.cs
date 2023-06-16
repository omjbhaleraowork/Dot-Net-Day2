namespace EmployeeAuto
{
    internal class EmpMain
    {
        static void Main(string[] args)
        {
            EmpAuto empAuto1 = new EmpAuto("om",50000,1);
            EmpAuto empAuto2 = new EmpAuto("shiv", 60000, 2);
            EmpAuto empAuto3 = new EmpAuto("manish", 40000);
            EmpAuto empAuto4 = new EmpAuto("satish");
            EmpAuto empAuto5 = new EmpAuto();
        }
    }
}