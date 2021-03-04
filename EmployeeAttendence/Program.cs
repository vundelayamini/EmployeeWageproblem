
using System;

namespace Employee_Details
{
    class Program
    {
         public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 50;
        public const int NUM_OF_WORKING_DAYS = 20;
        static void Main(string[] args)
        {
          //variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            //computation
            for (int temp = 0; temp < NUM_OF_WORKING_DAYS; temp++)
            {
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
            }
            Console.WriteLine("Total Monthly Emp Wage : " + totalEmpWage);

        }
    }
}
