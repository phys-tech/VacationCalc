using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationCalc.Model
{
    public class Employee
    {
        // required
        private string name;
        private DateTime hireDate;
        private EmploymentType accountType;

        // calculated
        public int TotalVacationDays;
        public int VacationDaysLeft;
        public int VacationDaysSpent;


        public Employee(string _name, DateTime _hireDate, EmploymentType _type)
        {
            name = _name;
            hireDate = _hireDate;
            accountType = _type;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public EmploymentType AccountType
        {
            get { return accountType; }
            set { accountType = value; }            
        }

        public int GetVacationDaysLeft()
        {
            return VacationDaysLeft;
        }
    }

}
