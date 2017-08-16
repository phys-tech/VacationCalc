using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationCalc.Model
{
    public class FiredEmployee : Employee
    {
        private DateTime fireDate;

        public DateTime FireDate 
        {
            get { return fireDate; }
            set { fireDate = value; }
        }

        public FiredEmployee(string _name, DateTime _hireDate, EmploymentType _type, bool _fired, DateTime _birth, string _mobile, ref HolidayManager _holidays)
            : base(_name, _hireDate, _type, _fired, _birth, _mobile, ref _holidays)
        {
            FireDate = DateTime.Now;
            calculator = new FiredDaysCalculator(this);
        }

        public sealed override object[] GetAsDataRow()
        {
            string name = Name;
            DateTime date = HireDate;
            FireDate = DateTime.Now;
            EmploymentType type = AccountType;
            string duration = ((FiredDaysCalculator)calculator).durationOfWork.ToString("dd");
            int vacation = calculator.VacationDaysLeft;
            object[] row = { 0, name, date, FireDate, type, duration, vacation };
            return row;
        }
    }

    

    
}
