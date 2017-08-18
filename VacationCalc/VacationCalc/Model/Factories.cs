using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationCalc.Model
{

    public static class EmployeeFactory
    {
        public static Employee Create(string _name, DateTime _hireDate, EmploymentType _accType, DateTime _fireDate, DateTime _birthday, string _mobile, ref HolidayManager _holidays)
        {
            bool fired = _fireDate != DateTime.MaxValue;
            if (fired)
                return new FiredEmployee(_name, _hireDate, _accType, _fireDate, _birthday, _mobile, ref _holidays);
            else
                return new Employee(_name, _hireDate, _accType, false, _birthday, _mobile, ref _holidays);
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
