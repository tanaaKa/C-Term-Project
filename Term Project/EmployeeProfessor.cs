using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Term_Project
{
    public class EmployeeProfessor: Employee
    {
        private double pfvAnnualSalary;
        private const double MAX_SALARY = 1000000;
        private const double MIN_SALARY = 0;

        public EmployeeProfessor()
        {
            throw new System.NotImplementedException();
        }

        public EmployeeProfessor(int Emp_ID, string First_Name, string Last_Name, string Mailing_Address, Department Emp_Dept, double Annual_Salary)
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