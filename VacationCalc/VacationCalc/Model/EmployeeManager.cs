﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using System.IO;


namespace VacationCalc.Model
{
    using EmployeeDict = Dictionary<int, Employee>;

    public class EmployeeManager
    {
        private EmployeeDict Employees;
        private const string XmlFilename = "EmployeesVacations.xml";

        public EmployeeManager()
        {
            Employees = new Dictionary<int, Employee>(25);
        }

        private int GetNewID()
        { 
            int id = 0;
            for (; ; id++)
                if (!Employees.ContainsKey(id))
                    return id;        
        }

        public int AddEmployee(string _name, DateTime _hireDate, EmploymentType _accType, DateTime _birthday)
        {
            int id = GetNewID();
            Employee employee = new Employee(_name, _hireDate, _accType, false, _birthday);
            Employees.Add(id, employee);
            DaysCalculator calc = new DaysCalculator(employee);
            return id;
        }

        public Employee GetEmployee(int id)
        {
            return Employees.ElementAtOrDefault(id).Value;
        }

        public void DeleteEmployee(int id)
        {
            Employees.Remove(id);
        }

        public EmployeeDict GetAllEmployees()
        {
            return Employees;   
        }

        public void ChangeName(int id, string newName)
        {
            Employees[id].Name = newName;
        }

        public void ChangeHireDate(int id, DateTime newDate)
        {
            Employees[id].HireDate = newDate;
        }

        public void ChangeType(int id, EmploymentType type)
        {
            Employees[id].AccountType = type;
        }

        public void ChangeBirthday(int id, DateTime newBirtday)
        {
            Employees[id].BirthDate = newBirtday;
        }

        public bool AddVacation(int id, Vacation vacation)
        {
            return Employees[id].AddVacation(vacation);
        }

        public void SaveDataToXML()
        {
            XDocument doc = new XDocument(new XElement("Root"));
            foreach (Employee employee in Employees.Values)
            {
                XElement element = new XElement("Employee",
                                    new XElement("Name", employee.Name),
                                    new XElement("HireDate", employee.HireDate),
                                    new XElement("AccountType", employee.AccountType),
                                    new XElement("IsFired", employee.IsFired),
                                    new XElement("BirthDate", employee.BirthDate),
                                    new XElement("Vacations"));
                var list = employee.GetVacationsList();
                foreach (Vacation item in list)
                {
                    XElement vacationElem;
                    if (!item.IsDateDefined)
                        vacationElem = new XElement("Vacation",
                                       new XAttribute("Duration", item.Duration.Days));
                    else
                        vacationElem = new XElement("Vacation",
                                       new XElement("StartDate", item.StartDate),
                                       new XElement("EndDate", item.EndDate));
                    element.Element("Vacations").Add(vacationElem);
                }
                doc.Root.Add(element);
            }
            doc.Save(XmlFilename);
        }

        public bool LoadDataFromXml()
        {
            XDocument doc = XDocument.Load(XmlFilename);
            try
            {
                foreach (XElement element in doc.Root.Elements())
                {
                    string name = element.Element("Name").Value.ToString();
                    DateTime date = DateTime.Parse(element.Element("HireDate").Value.ToString());
                    EmploymentType type = (EmploymentType)Enum.Parse(typeof(EmploymentType), element.Element("AccountType").Value.ToString());
                    bool fired = bool.Parse(element.Element("IsFired").Value);

                    var tempDate = element.Elements("BirthDate").DefaultIfEmpty(new XElement("Default", new DateTime(2000, 1, 1)));
                    DateTime birth = DateTime.Parse(tempDate.First().Value.ToString());

                    int id = GetNewID();
                    Employees.Add(id, new Employee(name, date, type, fired, birth));
                    XElement vacations = element.Element("Vacations");
                    foreach (XElement vacationElem in vacations.Elements())
                    {
                        if (vacationElem.HasAttributes)
                        {
                            int duration = int.Parse(vacationElem.Attribute("Duration").Value.ToString());
                            AddVacation(id, new Vacation(duration));
                        }
                        else
                        {
                            DateTime start = DateTime.Parse(vacationElem.Element("StartDate").Value.ToString());
                            DateTime end = DateTime.Parse(vacationElem.Element("EndDate").Value.ToString());
                            AddVacation(id, new Vacation(start, end));
                        }
                    }
                }
            }
            catch (Exception exc)
            {             
                return false;                
            }
            return true;
        }

        public int NumberOfEmployees()
        {
            return Employees.Count(e => !e.Value.IsFired);
        }

        public int NumberOfEmployeesOnVacation(out string empNames)
        {
            int onVacation = 0;
            empNames = "";
            foreach (Employee emp in Employees.Values)
                if (emp.IsOnVacation())
                {
                    onVacation++;
                    empNames += emp.Name + "\n";
                }
            return onVacation;
        }

    }
}
