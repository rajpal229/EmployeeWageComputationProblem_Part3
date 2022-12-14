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
            int perHour = 20;
            int fullTime = 8;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == empPresent)
            {
                Console.WriteLine("Employee is Present");
                int perDay = perHour * fullTime;
                Console.WriteLine("Daily wadge : " + perDay);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
