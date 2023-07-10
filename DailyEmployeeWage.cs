﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblemUsingOops
{
    class DailyEmployeeWage
    {
        const int EMP_RAT_PER_HOUR=20;
        const int IS_FULL_TIME=1;
        const int IS_PART_TIME=2;
        const int NUM_OF_WORKING_DAY=20;
        
        public int CalculateEmployeeDailyWage()
        {
            int empHour = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAY; day++)
            {
            Random random = new Random();
            int empCheck = random.Next(3);
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHour = 8;
                    break;
                case IS_PART_TIME:
                    empHour = 4;
                    break;
                default:
                    empHour = 0;
                    break;
            }            
            empWage = empHour * EMP_RAT_PER_HOUR;
            Console.WriteLine("Employee Wage :" + empWage);
            totalEmpWage += empWage;
        }
        return totalEmpWage;
        }
    }
}
