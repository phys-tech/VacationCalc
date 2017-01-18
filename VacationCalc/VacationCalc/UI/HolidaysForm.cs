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
        private IEnumerable<DateTime> localDates;

        public HolidaysForm(HolidayManager _holidayManager)
        {
            InitializeComponent();
            holidayManager = _holidayManager;
            localDates = holidayManager.Holidays;
            calendarHolidays.SelectedDates.AddRange(localDates.ToArray());
            UpdateDatesOnLabel();        
        }

        private void UpdateDatesOnLabel()
        {
            listViewSelectedDates.Items.Clear();
            foreach (DateTime date in localDates)
                listViewSelectedDates.Items.Add(date.ToLongDateString());
        }

        private void calendarHolidays_SelectionChanged(object sender, EventArgs e)
        {            
            localDates = calendarHolidays.SelectedDates;
            localDates = localDates.OrderBy(u => u.Date);
            UpdateDatesOnLabel();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            holidayManager.SetNewDates(localDates);
            this.Close();
        }


    }
}
