using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Term_Project
{
    public class EmployeeHourly: Employee
    {
        private const double MAX_HOURLYRATE = 100;
        private const double MAX_HOURS = 80;
        private const double MIN_HOURLYRATE = 7.45;
        private const double MIN_HOURS = 0;
        private double pfvHourlyRate;
        private double pfvHours;

        public EmployeeHourly()
        {
            throw new System.NotImplementedException();
        }

        public EmployeeHourly(int Emp_ID, string First_Name, string Last_Name, string Mailing_Address, Department Emp_Dept, double Hourly_Rate)
        {
            throw new System.NotImplementedException();
        }

        public double HourlyRate
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public double Hours
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