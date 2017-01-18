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

        public event EventHandler VacationChanged;

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

        public Vacation(int DurationInDays, ref HolidayManager _holidays)
        {
            duration = new TimeSpan(DurationInDays, 0, 0, 0);
            IsDateDefined = false;
            holidayManager = _holidays;
        }

        public Vacation(Vacation copy)
        {
            if (copy.IsDateDefined)
            {
                startDate = copy.startDate;
                endDate = copy.endDate;
                duration = copy.duration;
            }
            else
            {
                duration = copy.duration;
            }
            IsDateDefined = copy.IsDateDefined;
            holidayManager = copy.holidayManager;

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

        public virtual void OnHolidaysChanged(object sender, EventArgs e)
        {
            //System.Console.WriteLine("Vacation.HolidaysCalendarChanged - RecalcDuration");
            this.RecalcDuration();
            OnVacationChanged(null);
        }

        protected virtual void OnVacationChanged(EventArgs e)
        {
            EventHandler handler = VacationChanged;
            if (handler != null)
                handler(this, e);
        }

    }


    public class VacationIp : Vacation
    {
        public VacationIp(DateTime _startDate, DateTime _endDate)
            : base(_startDate, _endDate)
        { }

        public VacationIp(Vacation copy)
            : base(copy)
        {
            holidayManager.HolidaysChanged += OnHolidaysChanged;
        }

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

        public override void OnHolidaysChanged(object sender, EventArgs e)
        {
            //System.Console.WriteLine("VacationIP.HolidaysCalendarChanged - RecalcDuration");
            this.RecalcDuration();
            OnVacationChanged(null);
        }

    }


    public class VacationOoo : Vacation
    {
        public VacationOoo(DateTime _startDate, DateTime _endDate)
            : base(_startDate, _endDate)
        { }

        public VacationOoo(Vacation copy)
            : base(copy)
        {
            holidayManager.HolidaysChanged += OnHolidaysChanged;
        }

        protected override void RecalcDuration()
        {
            //System.Console.WriteLine("Derived VacationOOO: RecalcDuration() call");
            duration = endDate - startDate;
            duration = duration.Add(new TimeSpan(1, 0, 0, 0));
        }

        public override void OnHolidaysChanged(object sender, EventArgs e)
        {
            //System.Console.WriteLine("VacationOOO.HolidaysCalendarChanged - RecalcDuration");
            this.RecalcDuration();
            OnVacationChanged(null);
        }

    }
}
