using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSolution
{
    public class EmpWageBuilder
    {
        public const int IS_PART_TIMe = 1;
        public const int IS_FULL_TIME = 2;
        private LinkdList<CompanyEmpWage> comapnyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.comapnyEmpWageList = new LinkdList(CompanyEmpWage)
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
         { 
            CompanyEmpWage CompanyEmpWage = new CompanyEmpWage(CompanyEmpWage, empRateperHour, numOfworkingDays, maxHoursperMonth);
            
            this.comapnyEmpWageList.AddLast(CompanyEmpWage);
            this.companyEmpWageMap.Add(company, CompanyEmpWage);
        }
    
}

 }

}
