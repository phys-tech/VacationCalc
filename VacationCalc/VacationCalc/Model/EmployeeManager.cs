using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using System.IO;


namespace VacationCalc.Model
{
    public class EmployeeManager
    {
        private Dictionary<int, Employee> Employees;
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


        public void AddEmployee(string _name, DateTime _hireDate, EmploymentType _accType)
        {
            int id = GetNewID();
            Employee employee = new Employee(_name, _hireDate, _accType);
            Employees.Add(id, employee);
        }

        public void SaveDataToXML()
        {
            XDocument doc = new XDocument(new XElement("Root"));
            foreach (Employee employee in Employees.Values)
            {
                XElement element = new XElement("Employee",
                                    new XElement("Name", employee.GetName()),
                                    new XElement("HireDate", employee.GetHireDate()),
                                    new XElement("AccountType", employee.GetAccountType()));
                doc.Root.Add(element);
            }            
            doc.Save(XmlFilename);
        }
    }
}
