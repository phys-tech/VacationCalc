using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace VacationCalc.Model
{
    public class Employee
    {
        // required
        private string name;
        private DateTime hireDate;
        private EmploymentType accountType;
        private List<Vacation> vacationList;
        private bool fired;
        private DateTime birthDate;
        private string mobilePhone;

        // calculator keeps all the calculated data inside
        public DaysCalculator calculator;
        public HolidayManager holidayManager;
        public event EventHandler FiredOrHired;

        /*public Employee(string _name, DateTime _hireDate, EmploymentType _type, bool _fired, DateTime _birth, string _mobile)
        {
            name = _name;
            hireDate = _hireDate;
            accountType = _type;
            fired = _fired;
            birthDate = _birth;
            mobilePhone = _mobile;
            vacationList = new List<Vacation>();
            calculator = new DaysCalculator(this);
        }*/

        public Employee(string _name, DateTime _hireDate, EmploymentType _type, bool _fired, DateTime _birth, string _mobile, ref HolidayManager _holidays)
        {
            name = _name;
            hireDate = _hireDate;
            accountType = _type;
            fired = _fired;
            birthDate = _birth;
            mobilePhone = _mobile;
            vacationList = new List<Vacation>();
            holidayManager = _holidays;
            calculator = new DaysCalculator(this);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; calculator.FillEmployeeData(); }
        }

        public EmploymentType AccountType
        {
            get { return accountType; }
            set { accountType = value; calculator.FillEmployeeData(); }
        }

        public bool IsFired 
        {
            get { return fired; }    //return (this.GetType() == typeof(FiredEmployee));
            set { fired = value; FiredOrHired.Invoke(this, null); }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }

        public virtual object[] GetAsDataRow()
        {
            string name = Name;
            DateTime date = HireDate;
            EmploymentType type = AccountType;
            int vacation = calculator.VacationDaysLeft;
            DateTime birth = BirthDate;
            string mobile = MobilePhone;
            object[] row = { 0, name, date, type, vacation, birth, mobile };
            return row;
        }

        public virtual XElement GetAsXElement()
        {
            XElement element = new XElement("Employee",
                                new XElement("Name", Name),
                                new XElement("HireDate", this.HireDate),
                                new XElement("AccountType", this.AccountType),
                                new XElement("IsFired", this.IsFired),
                                new XElement("BirthDate", this.BirthDate),
                                new XElement("MobilePhone", this.MobilePhone),
                                new XElement("Vacations"));
            return element;
        }

        public Vacation CreateProperVacation(Vacation vacationBase)
        {
            return VacationFactory.Create(AccountType, vacationBase);
        }

        public bool AddVacation(Vacation newVacation)
        {
            if (newVacation.IsDateDefined)
                if (IsVacationInterfering(newVacation))
                    return false;

            Vacation derived = CreateProperVacation(newVacation);
            derived.VacationChanged += OnVacationChanged;
            vacationList.Add(derived);
            calculator.FillEmployeeData();
            return true;
        }

        public void DeleteVacation(Vacation vacation)
        {
            if (vacation.IsDateDefined)
            {
                var deleters = vacationList.Where(item => item.StartDate == vacation.StartDate && item.EndDate == vacation.EndDate);
                vacationList.Remove(deleters.First());
            }
            else
            {
                var deleters = vacationList.Where(item => item.Duration == vacation.Duration);
                vacationList.Remove(deleters.First());
            }
            calculator.FillEmployeeData();
        }

        public bool ChangeStartDate(DateTime newStart, DateTime endDate)
        {
            var oldVacationList = vacationList.Where(item => item.EndDate == endDate);
            Vacation newVacation = new Vacation(newStart, endDate, ref holidayManager);
            Vacation oldVacationCopy = new Vacation(oldVacationList.First());

            DeleteVacation(oldVacationList.First());
            if (AddVacation(newVacation))
            {
                calculator.FillEmployeeData();
                return true;
            }
            else
            {
                AddVacation(oldVacationCopy);
                return false;
            }
        }

        public bool ChangeEndDate(DateTime startDate, DateTime newEnd)
        {
            var oldVacationList = vacationList.Where(item => item.StartDate == startDate);
            Vacation newVacation = new Vacation(startDate, newEnd, ref holidayManager);
            Vacation oldVacationCopy = new Vacation(oldVacationList.First());

            DeleteVacation(oldVacationList.First());
            if (AddVacation(newVacation))
            {
                calculator.FillEmployeeData();
                return true;
            }
            else
            {
                AddVacation(oldVacationCopy);
                return false;
            }
        }

        private bool IsVacationInterfering(Vacation candidate)
        {
            foreach (Vacation existing in vacationList)
            {
                if (candidate.StartDate >= existing.StartDate && candidate.StartDate <= existing.EndDate)
                    return true;
                if (candidate.EndDate >= existing.StartDate && candidate.EndDate <= existing.EndDate)
                    return true;
                if (existing.StartDate >= candidate.StartDate && existing.StartDate <= candidate.EndDate)
                    return true;
                if (existing.EndDate >= candidate.StartDate && existing.EndDate <= candidate.EndDate)
                    return true;
            }
            return false;
        }

        public List<Vacation> GetVacationsList()
        {
            return vacationList;
        }

        public bool IsOnVacation()
        { 
            DateTime today = DateTime.Today;
            foreach (Vacation vacation in vacationList)
                if (vacation.IsDateDefined)
                    if (vacation.StartDate <= today && vacation.EndDate >= today)
                        return true;
            return false;
        }

        public void OnVacationChanged(object sender, EventArgs e)
        {
            calculator.FillEmployeeData();
        }

    }

}
