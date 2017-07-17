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
            //calculator = new DaysCalculator(this);
        }

        public sealed override object[] GetAsDataRow()
        {
            string name = Name;
            DateTime date = HireDate;
            EmploymentType type = AccountType;
            int vacation = 33;//  calculator.VacationDaysLeft;
            object[] row = { 0, name, date, type, vacation };
            return row;
        }
    }

    
    public static class EmployeeFactory
    {
        public static Employee Create(string _name, DateTime _hireDate, EmploymentType _accType, bool _fired, DateTime _birthday, string _mobile, ref HolidayManager _holidays)
        {
            if (_fired)
                return new FiredEmployee(_name, _hireDate, _accType, _fired, _birthday, _mobile, ref _holidays);
            else
                return new Employee(_name, _hireDate, _accType, _fired, _birthday, _mobile, ref _holidays);
        }
    }
    
}
