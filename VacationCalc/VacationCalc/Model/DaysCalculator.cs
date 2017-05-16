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
    
        private int TotalDaysOfWork()
        {
            var days = (DateTime.Today - CurrentEmployee.HireDate).TotalDays;
            var floored = Math.Floor(days);
            int result = (int)floored;
            return result;        
        }

        private int TotalVacationEarned()
        {
            int workingDays = TotalDaysOfWork();
            int vacationPerYear = CurrentEmployee.AccountType.GetVacationDaysPerYear();
            var vacation = (double) workingDays / 365.0 * vacationPerYear;
            return (int) vacation;
        }

        private int CountVacationDaysSpent()
        {
            int days = 0;
            foreach (Vacation item in CurrentEmployee.GetVacationsList())
                days += item.Duration.Days;
            return days;
        }

        private int CountVacationAtYearEnd()
        { 
            DateTime endOfYear = new DateTime(DateTime.Today.Year, 12, 31);
            var daysWorkedAtEnd = (endOfYear - CurrentEmployee.HireDate).TotalDays;
            var floored = Math.Floor(daysWorkedAtEnd);
            int vacationPerYear = CurrentEmployee.AccountType.GetVacationDaysPerYear();
            var vacation = floored / 365.0 * vacationPerYear;
            return (int)vacation;
        }

        public void FillEmployeeData()
        {
            TotalVacationDays = TotalVacationEarned();
            VacationDaysSpent = CountVacationDaysSpent();
            VacationDaysLeft = TotalVacationDays - VacationDaysSpent;
            VacationDaysAtYearEnd = CountVacationAtYearEnd() - VacationDaysSpent;
        }
    
    }
}
