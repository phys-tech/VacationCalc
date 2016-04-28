﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationCalc.Model
{
    public class DaysCalculator
    {
        private Employee CurrentEmployee;

        DaysCalculator(Employee _employee)
        {
            CurrentEmployee = _employee;
        }
    
        public int TotalDaysOfWork()
        {
            var days = (DateTime.Today - CurrentEmployee.GetHireDate()).TotalDays;
            var floored = Math.Floor(days);
            int result = (int)floored;
            return result;        
        }

        public int TotalVacationEarned()
        {
            int workingDays = TotalDaysOfWork();
            int vactionPerYear = CurrentEmployee.GetAccountType().GetVacationDaysPerYear();
            var vacation = (double) workingDays / 365.0 * vactionPerYear;
            return vactionPerYear;
        }

        public void FillEmployeeData()
        {
            CurrentEmployee.TotalVacationDays = TotalVacationEarned();
            CurrentEmployee.VacationDaysLeft = CurrentEmployee.TotalVacationDays;
        }
    
    }
}