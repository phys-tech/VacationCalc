using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationCalc.Model
{
    public class Vacation
    {
        protected DateTime startDate;
        protected DateTime endDate;
        protected TimeSpan duration;
        protected HolidayManager holidayManager;
        public bool IsDateDefined;

        protected Vacation()
        {
            startDate = new DateTime();
            endDate = new DateTime();
            duration = new TimeSpan();
            IsDateDefined = false;
        }

        public Vacation(DateTime _startDate, DateTime _endDate)
        {
            startDate = (_startDate < _endDate) ? (_startDate) : (_endDate);
            endDate = (_startDate < _endDate) ? (_endDate) : (_startDate);
            RecalcDuration();
            IsDateDefined = true;
        }

        public Vacation(DateTime _startDate, DateTime _endDate, ref HolidayManager _holidays)
        {
            startDate = (_startDate < _endDate) ? (_startDate) : (_endDate);
            endDate = (_startDate < _endDate) ? (_endDate) : (_startDate);
            RecalcDuration();
            IsDateDefined = true;
            holidayManager = _holidays;
        }

        public Vacation(int DurationInDays)
        {
            duration = new TimeSpan(DurationInDays, 0, 0, 0);
            IsDateDefined = false;
        }

        public Vacation(Vacation copy)
        {
            if (copy.IsDateDefined)
            {
                startDate = copy.startDate;
                endDate = copy.endDate;
                duration = copy.duration;
                holidayManager = copy.holidayManager;
                IsDateDefined = copy.IsDateDefined;
            }
            RecalcDuration();
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; RecalcDuration(); }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; RecalcDuration(); }
        }

        public virtual TimeSpan Duration
        {
            get { return duration; }
        }

        protected virtual void RecalcDuration()
        {
            //System.Console.WriteLine("Base Vacation: RecalcDuration() call");
            duration = endDate - startDate;
            duration = duration.Add(new TimeSpan(1, 0, 0, 0));
        }

    }


    public class VacationIp : Vacation
    {
        public VacationIp(DateTime _startDate, DateTime _endDate)
            : base(_startDate, _endDate)
        { }

        public VacationIp(Vacation copy)
            : base(copy)
        { }

        protected override void RecalcDuration()
        {
            //System.Console.WriteLine("Derived VacationIP: RecalcDuration() call");
            int days = 0;
            for (DateTime current = startDate; current <= endDate; current = current.AddDays(1.0))
            {
                if (current.DayOfWeek != DayOfWeek.Saturday && current.DayOfWeek != DayOfWeek.Sunday &&
                        !holidayManager.Holidays.Contains(current.Date))
                    days++;
            }
            duration = new TimeSpan(days, 0, 0, 0);
            
        }
    }


    public class VacationOoo : Vacation
    {
        public VacationOoo(DateTime _startDate, DateTime _endDate)
            : base(_startDate, _endDate)
        { }

        public VacationOoo(Vacation copy)
            : base(copy)
        { }        

        protected override void RecalcDuration()
        {
            //System.Console.WriteLine("Derived VacationOOO: RecalcDuration() call");
            duration = endDate - startDate;
            duration = duration.Add(new TimeSpan(1, 0, 0, 0));
        }


    }
}
