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


        public void AddEmployee(string _name, DateTime _hireDate, EmploymentType _accType)
        {
            int id = GetNewID();
            Employee employee = new Employee(_name, _hireDate, _accType);
            Employees.Add(id, employee);
        }

        public EmployeeDict GetAllEmployees()
        {
            return Employees;   
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

        public void LoadDataFromXml()
        {
            XDocument doc = XDocument.Load(XmlFilename);
            foreach (XElement element in doc.Root.Elements())
            {
                string name = element.Element("Name").Value.ToString();
                DateTime date = DateTime.Parse(element.Element("HireDate").Value.ToString());
                //EmploymentType type = (EmploymentType) (element.Element("AccountType").Value.ToString());
                EmploymentType type = EmploymentType.IP;
                int id = GetNewID();
                Employees.Add(id, new Employee(name, date, type));
            }
        }
    }
}
