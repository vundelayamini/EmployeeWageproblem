
using System;

namespace Employee_Details
{
    class Program
    {
         public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        static void Main(string[] args)
        {
          //variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            //computation
            while(totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkinDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 2:
                        empHrs = 4;
                        break;
                    case 1:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmphrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }
              int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
              Console.WriteLine("total Emp Wage :" + totalEmpWage)
    }
}
