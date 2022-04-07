﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWageComputation
{
    public class wageComputation
    {
        const int IS_PRESENT = 0, WAGE_PER_HR = 20, FULL_TIME_HR = 8,
            PART_TIME_HR = 4, IS_FULLTIME=0, IS_PARTTIME=1;
        int empHrs, totalEmpWage;
        public void EmployeeAttendance()
        {
            
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
        public void DailyEmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULLTIME)
            {
                empHrs = FULL_TIME_HR;
            }
            else if(empCheck==IS_PARTTIME)
            {
                empHrs = PART_TIME_HR;
            }
            else
            {
                empHrs = 0;
            }
            totalEmpWage = empHrs * WAGE_PER_HR;
            Console.WriteLine("Total empWage for a day"  + totalEmpWage);
        }
    }
}
