using System;

namespace EmployeeWageProblemUsingOops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Problem using oops");
            var employeeWage = new DailyEmployeeWage();
            int empTotalWage =employeeWage.CalculateEmployeeDailyWage();
            Console.WriteLine("Employee Total Wage "+ empTotalWage);
        }
    }
}
