using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblemUsingOops
{
    class DailyEmployeeWage
    {
        int EMP_RAT_PER_HOUR;
        int IS_FULL_TIME;
        int IS_PART_TIME;
        public DailyEmployeeWage(int employeeRatePerHrs, int isFullTime,int isPartTime)
        {
            EMP_RAT_PER_HOUR = employeeRatePerHrs;
            IS_FULL_TIME = isFullTime;
            IS_PART_TIME = isPartTime;
        }
        public int CalculateEmployeeDailyWage()
        {
            int empHour = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(3);
            if (empCheck == IS_FULL_TIME)
                empHour = 8;
            else if (empCheck == IS_PART_TIME)
                empHour = 4;
            else
                empHour = 0;
            return empWage = empHour * EMP_RAT_PER_HOUR;
        }
    }
}
