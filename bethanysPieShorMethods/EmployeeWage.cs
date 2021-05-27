using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopMethods
{
    public class EmployeeWage
    {
        public EmployeeWage CalculateYearlyWage()
        {
            int wagePerMonth = 5;
            int months = 6;
            EmployeeWage this2 = new EmployeeWage();
            Console.WriteLine($"add two variables to get yearly wage: {wagePerMonth + months}");
           
            return this2;
        }



    }
}
