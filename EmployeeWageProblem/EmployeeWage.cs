using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageproblem
{
    class EmpWage
    { 
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage; public Empwage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        
          public static int calculateEmployee()
           {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays <= NUMBER_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                     empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            return totalEmpWage;
        }
        static void Main(String[] args)
        {

            Console.WriteLine($"Total Employee Wage is : {calculateEmployee()}");
        }
}
