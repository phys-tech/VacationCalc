using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationCalc.Model
{
    public class EmployeeManager
    {
        private Dictionary<int, Employee> Employees;

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
        }


    }
}
