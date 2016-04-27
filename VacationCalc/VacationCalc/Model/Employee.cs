using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationCalc.Model
{
    class Employee
    {
        // required
        private string Name;
        private DateTime HireDate;
        private EmploymentType AccountType;

        // calculated
        public int TotalVacationDays;
        public int VacationDaysLeft;
        public int VacationDaysSpent;


        public Employee(string _name, DateTime _hireDate, EmploymentType _type)
        {
            Name = _name;
            HireDate = _hireDate;
            AccountType = _type;
        }

        public DateTime GetHireDate()
        {
            return HireDate;
        }

        public EmploymentType GetAccountType()
        { 
            return AccountType;
        }

        public int GetVacationDaysLeft()
        {
            return VacationDaysLeft;
        }
    }

}
