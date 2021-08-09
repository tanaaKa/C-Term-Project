using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Term_Project
{
    public abstract class Employee
    {
        const int MAX_EMPID = 10000;
        const int MIN_EMPID = 1000;
        protected string pfvAddress;
        protected Department pfvDept;
        protected int pfvEmpID;
        protected string pfvFirstName;
        protected string pfvLastName;

        public Employee()
        {
            
        }

        public Employee(int Emp_ID, string First_Name, string Last_Name, string Mailing_Address, Department Emp_Dept)
        {
            FirstName = First_Name;
            LastName = Last_Name;
            Address = Mailing_Address;
            Dept = Emp_Dept;

            EmpID = Emp_ID;
        }

        public string Address
        {
            get
            {
                return pfvAddress;
            }

            set
            {
                pfvAddress = value;
            }
        }

        public Department Dept
        {
            get
            {
                return pfvDept;
            }

            set
            {
                pfvDept = value;
            }
        }

        public int EmpID
        {
            get
            {
                return pfvEmpID;
            }

            set
            {
                pfvEmpID = value;
            }
        }

        public string FirstName
        {
            get
            {
                return pfvFirstName;
            }

            set
            {
                pfvFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return LastName;
            }

            set
            {
                pfvLastName = value;
            }
        }

        public double CalcPay()
        {
            return 0;
        }
    }
}