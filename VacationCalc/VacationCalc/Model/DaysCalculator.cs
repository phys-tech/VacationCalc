using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationCalc.Model
{
    public class DaysCalculator
    {
        private Employee CurrentEmployee;
        public int TotalVacationDays;
        public int VacationDaysSpent;
        public int VacationDaysLeft;
        public int VacationDaysAtYearEnd;

        public DaysCalculator(Employee _employee)
        {
            CurrentEmployee = _employee;
            FillEmployeeData();
        }
    
        private int TotalDaysOfWork(DateTime dateToCount)
        {
            var days = (dateToCount - CurrentEmployee.HireDate).TotalDays;
            var floored = Math.Floor(days);
            int result = (int)floored;
            return result;        
        }

        private int TotalVacationEarned(DateTime dateToCount)
        {
            int daysWorked = TotalDaysOfWork(dateToCount);
            int vacationPerYear = CurrentEmployee.AccountType.GetVacationDaysPerYear();
            var vacation = (double) daysWorked / 365.0 * vacationPerYear;
            return (int) vacation;
        }

        private int CountVacationDaysSpent()
        {
            int days = 0;
            foreach (Vacation item in CurrentEmployee.GetVacationsList())
                days += item.Duration.Days;
            return days;
        }

        private DateTime EndOfYear
        {
            get { return new DateTime(DateTime.Today.Year, 12, 31); }
        }

        public void FillEmployeeData()
        {
            TotalVacationDays = TotalVacationEarned(DateTime.Today);
            VacationDaysSpent = CountVacationDaysSpent();
            VacationDaysLeft = TotalVacationDays - VacationDaysSpent;
            VacationDaysAtYearEnd = TotalVacationEarned(EndOfYear) - VacationDaysSpent;
        }
    
    }
}
