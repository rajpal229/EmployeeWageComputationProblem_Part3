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
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            int empPresent = 1;
            int empPartTime = 2;
            int perHour = 20;
            int fullTime = 8;
            int partTime = 4;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == empPresent)
            {
                Console.WriteLine("Employee is Present Full-Time");
                int DailyWage = perHour * fullTime;
                Console.WriteLine("Daily wadge : " + DailyWage);
            }
            else if (check == empPartTime)
            {
                Console.WriteLine("Employee is Present Part-Time");
                int DailyWage = perHour * partTime;
                Console.WriteLine("Daily wadge : " + DailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
