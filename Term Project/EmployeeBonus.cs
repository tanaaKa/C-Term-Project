using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Term_Project
{
    public class EmployeeBonus: Employee
    {
        private double pfvAnnualSalary;
        private double pfvBonus;
        private const double MAX_BONUS = .10;
        private const double MAX_SALARY = 1000000;
        private const double MIN_BONUS = 0;
        private const double MIN_SALARY = 0;

        public EmployeeBonus()
        {
            throw new System.NotImplementedException();
        }

        public EmployeeBonus(int Emp_ID, string First_Name, string Last_Name, string Mailing_Address, Department Emp_Dept, double Annual_Salary)
        {
            throw new System.NotImplementedException();
        }

        public double AnnualSalary
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public double Bonus
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public double CalcPay()
        {
            throw new System.NotImplementedException();
        }

        public string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}