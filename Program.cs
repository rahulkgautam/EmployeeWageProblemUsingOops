using System;

namespace EmployeeWageProblemUsingOops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Problem using oops");
            var employeeWage = new DailyEmployeeWage(20,1);
            var dailyWage = employeeWage.CalculateEmployeeDailyWage();
            Console.WriteLine("Employee Wage "+dailyWage);
        }
    }
}
