namespace EmployeWageComputationProblem_Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWage attendence= new EmpWage();
            attendence.CalculateSalary("Company1", 40, 20, 100);
            attendence.CalculateSalary("Company2", 40, 25, 80);
        }
    }
}