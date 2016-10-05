﻿using System;
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
        private List<Vacation> vacationList;
        private DaysCalculator calculator;
        private bool fired;

        // calculated
        public int TotalVacationDays;
        public int VacationDaysLeft;

        public Employee(string _name, DateTime _hireDate, EmploymentType _type, bool _fired)
        {
            name = _name;
            hireDate = _hireDate;
            accountType = _type;
            fired = _fired;
            vacationList = new List<Vacation>();
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
            get { return fired; }
            set { fired = value; }
        }

        public bool AddVacation(Vacation newVacation)
        {
            if (newVacation.IsDateDefined)
                if (IsVacationInterfering(newVacation))
                    return false;

            vacationList.Add(newVacation);
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
            Vacation newVacation = new Vacation(newStart, endDate);
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
            Vacation newVacation = new Vacation(startDate, newEnd);
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

        public int VacationDaysSpent()
        {
            int days = 0;
            foreach (Vacation item in vacationList)
            {
                if (item.IsDateDefined)
                    days += VacationDuration(item.StartDate, item.EndDate);
                else
                    days += item.Duration.Days;
            }
            return days;
        }

        public int VacationDuration(DateTime start, DateTime end)
        {
            int days = 0;
            if (accountType == EmploymentType.OOO)
                days += new Vacation(start, end).Duration.Days;

            else if (accountType == EmploymentType.IP)
                for (DateTime current = start; current <= end; current = current.AddDays(1.0))
                    if (current.DayOfWeek != DayOfWeek.Saturday && current.DayOfWeek != DayOfWeek.Sunday)
                        days++;
            return days;
        }

        public int GetVacationDaysLeft()
        {
            return VacationDaysLeft;
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
    }

}
