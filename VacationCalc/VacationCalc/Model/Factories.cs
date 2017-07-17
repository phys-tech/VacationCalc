using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationCalc.Model
{

    public static class EmployeeFactory
    {
        public static Employee Create(string _name, DateTime _hireDate, EmploymentType _accType, bool _fired, DateTime _birthday, string _mobile, ref HolidayManager _holidays)
        {
            if (_fired)
                return new FiredEmployee(_name, _hireDate, _accType, _fired, _birthday, _mobile, ref _holidays);
            else
                return new Employee(_name, _hireDate, _accType, _fired, _birthday, _mobile, ref _holidays);
        }
    }


    public static class VacationFactory
    { 
        public static Vacation Create(EmploymentType type, Vacation ancestor)
        {
            switch (type)
            {
                case EmploymentType.OOO:
                    return new VacationOoo(ancestor);
                case EmploymentType.IP:
                    return new VacationIp(ancestor);
                case EmploymentType.SVE:
                    return new VacationSve(ancestor);
                default:
                    return new Vacation(ancestor);
            }
        }
    }
}
