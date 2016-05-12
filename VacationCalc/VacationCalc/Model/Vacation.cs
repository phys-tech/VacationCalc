using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationCalc.Model
{
    public class Vacation
    {
        private DateTime startDate;
        private DateTime endDate;
        private TimeSpan duration;
        public bool IsDateDefined;

        public Vacation(DateTime _startDate, DateTime _endDate)
        {
            startDate = (_startDate < _endDate) ? (_startDate) : (_endDate);
            endDate = (_startDate < _endDate) ? (_endDate) : (_startDate);
            duration = endDate - startDate;
            duration = duration.Add(new TimeSpan(1,0,0,0));
            IsDateDefined = true;
        }

        public Vacation(int DurationInDays)
        {
            duration = new TimeSpan(DurationInDays, 0, 0, 0);
            IsDateDefined = false;
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public TimeSpan Duration
        {
            get { return duration; }
        }

    }
}
