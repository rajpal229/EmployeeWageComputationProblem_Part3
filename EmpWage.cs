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
            int fullTime = 8;
            int partTime = 4;
            int DailyWage = 0;
            Random random = new Random();
            int check = random.Next(0, 2);
            switch (check)
            {
                case 1:
                    Console.WriteLine("Employee is Present Full-Time");
                    DailyWage = perHour * fullTime;
                    Console.WriteLine("Daily wage : " + DailyWage);
                    break;
                case 2:
                    Console.WriteLine("Employee is Present Part-Time");
                    DailyWage = perHour * partTime;
                    break;
                default:
                    Console.WriteLine("Daily wage : " + DailyWage);
                    Console.WriteLine("Employee is Absent");
                    break;
            }
        }
    }
}
