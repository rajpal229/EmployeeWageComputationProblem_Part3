using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageComputationProblem_Part3
{
    internal class EmpWage
    {
        public void Attendence()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.ForegroundColor = ConsoleColor.Gray;
            int empPresent = 1;
            int empPartTime = 2;
            int perHour = 20;
            int maxDaysInMonth = 20;
            int empHrs = 0, dailyWage = 0, monthlyWage = 0;
            for (int days = 1; days <= maxDaysInMonth; days++)
            {
                Random random = new Random();
            int check = random.Next(0, 2);
            switch (check)
            {
                case 1:
                    Console.WriteLine("Employee is Present Full-Time");
                    empHrs = 8;
                    break;
                case 2:
                    Console.WriteLine("Employee is Present Part-Time");
                        empHrs = 4;
                        break;
                default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent");
                    break;
            }
                dailyWage = empHrs * perHour;
                 monthlyWage += dailyWage;
                Console.WriteLine("employee wage:" + dailyWage);
            }
            Console.WriteLine("total employee wage:" + monthlyWage);

        }
    }
}
