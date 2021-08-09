using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Term_Project
{
    public class EmployeeAdjunct: Employee
    {
        const double MAX_CONTRACT = 16000;
        const int MAX_WEEKS = 16;
        const double MIN_CONTRACT = 3000;
        const int MIN_WEEKS = 6;
        private double pfvContractAmount;
        private int pfvNumWeeks;

        public EmployeeAdjunct()
        {
           
        }

        public EmployeeAdjunct(int Emp_ID, string First_Name, string Last_Name, string Mailing_Address, Department Emp_Dept, double Contract_Amount, int Num_Weeks)
        {
            FirstName = First_Name;
            LastName = Last_Name;
            Address = Mailing_Address;
            Dept = Emp_Dept;

            EmpID = Emp_ID;
        }

        public double ContractAmount
        {
            get
            {
                return pfvContractAmount;
            }

            set
            {
                pfvContractAmount = value;
            }
        }

        public int NumWeeks
        {
            get
            {
                return pfvNumWeeks;
            }

            set
            {
                pfvNumWeeks = value;
            }
        }

        public double CalcPay()
        {
            return 0;
        }

        public new string ToString()
        {
            return $"EmpID={pfvEmpID}, EmpId={pfvEmpID}, FirstName={pfvFirstName}, LastName={pfvLastName}";
        }
    }
}