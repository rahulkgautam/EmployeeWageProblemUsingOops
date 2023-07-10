using System;

namespace EmployeeWageProblemUsingOops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Problem using oops");
            var employeeWage = new DailyEmployeeWage();
            var totalEmp =employeeWage.CalculateEmployeeDailyWage();
            Console.WriteLine("Total Working Days: " + totalEmp[0]);
            Console.WriteLine("Total Working Hours: " + totalEmp[1]);
            Console.WriteLine("Total Employee Wage : " + totalEmp[2]);

        }
    }
}
