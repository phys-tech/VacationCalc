using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

using VacationCalc.Model;

namespace VacationCalc.UI
{
    public partial class HolidaysForm : Telerik.WinControls.UI.RadForm
    {
        private HolidayManager holidayManager;

        public HolidaysForm(HolidayManager _holidayManager)
        {
            InitializeComponent();
            holidayManager = _holidayManager;
            calendarHolidays.SelectedDates.AddRange(holidayManager.Holidays.ToArray());
            UpdateDatesOnLabel();        
        }

        private void UpdateDatesOnLabel()
        {
            listViewSelectedDates.Items.Clear();
            foreach (DateTime date in holidayManager.Holidays)
                listViewSelectedDates.Items.Add(date.ToLongDateString());
        }

        private void calendarHolidays_SelectionChanged(object sender, EventArgs e)
        {            
            IEnumerable<DateTime> tempDates = calendarHolidays.SelectedDates;
            tempDates = tempDates.OrderBy(u => u.Date);
            holidayManager.Holidays = tempDates;
            UpdateDatesOnLabel();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            holidayManager.SaveDatesToXML();
            this.Close();
        }


    }
}
