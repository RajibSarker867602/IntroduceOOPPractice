using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    class Employee
    {
        public string employeeName;
        public decimal basicAmount;

        public decimal GetTotalSalary(decimal homeRent,decimal medicalAllowance)
        {
            decimal homeRentValue = (basicAmount * homeRent) / 100;
            decimal medicalAllowanceValue = (basicAmount * medicalAllowance) / 100;
            return basicAmount += homeRentValue + medicalAllowanceValue;
        }
    }
}
