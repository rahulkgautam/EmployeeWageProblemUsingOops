using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblemUsingOops
{
    class EmployeeAttendance
    {
        public string CheckEmployeeAttendance()
        {
            int IS_PRESENT = 1;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == IS_PRESENT)
                return "Employee is Present";
            else
                return "Employee is Absent";
        }
    }
}
