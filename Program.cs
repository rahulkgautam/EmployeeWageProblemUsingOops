﻿using System;

namespace EmployeeWageProblemUsingOops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Problem using oops");
            var employeeAttendance = new EmployeeAttendance();
            var isPresent =employeeAttendance.CheckEmployeeAttendance();
            Console.WriteLine(isPresent);
        }
    }
}
