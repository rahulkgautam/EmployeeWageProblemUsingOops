using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblemUsingOops
{
    class DailyEmployeeWage
    {
        const int EMP_RAT_PER_HOUR=20;
        const int IS_FULL_TIME=1;
        const int IS_PART_TIME=2;
        public int CalculateEmployeeDailyWage()
        {
            int empHour = 0;
            int empWage = 0;
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
