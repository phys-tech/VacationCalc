using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
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

        public FiredEmployee(string _name, DateTime _hireDate, EmploymentType _type, DateTime _fireDate, DateTime _birth, string _mobile, ref HolidayManager _holidays)
            : base(_name, _hireDate, _type, true, _birth, _mobile, ref _holidays)
        {
            FireDate = _fireDate;
            calculator = new FiredDaysCalculator(this);
        }

        public sealed override object[] GetAsDataRow()
        {
            string name = Name;
            DateTime date = HireDate;
            EmploymentType type = AccountType;
            string duration = ((FiredDaysCalculator)calculator).durationOfWork.ToString("dd");
            int vacation = calculator.VacationDaysLeft;
            object[] row = { 0, name, date, FireDate, type, duration, vacation };
            return row;
        }

        public override XElement GetAsXElement()
        {
            XElement element = new XElement("Employee",
                    new XElement("Name", Name),
                    new XElement("HireDate", this.HireDate),
                    new XElement("AccountType", this.AccountType),
                    new XElement("IsFired", this.IsFired),
                    new XElement("FireDate", this.FireDate),
                    new XElement("BirthDate", this.BirthDate),
                    new XElement("MobilePhone", this.MobilePhone),
                    new XElement("Vacations"));
            return element;
        }
    }

    

    
}
