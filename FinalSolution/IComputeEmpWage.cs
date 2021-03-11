using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSolution
{
    interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRateperHour, int numOfWorkingDays, int maxHoursperMonth);
        public void computeEmpWage();
        public int getTotalwage(string company);
    }

}
