using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace VacationCalc.UI
{
    public partial class HolidaysForm : Telerik.WinControls.UI.RadForm
    {
        private List<DateTime> dateList;
        public HolidaysForm()
        {
            InitializeComponent();
            dateList = new List<DateTime>();
        }

        private void calendarHolidays_SelectionChanged(object sender, EventArgs e)
        {
            labelSelectedDates.Text = "";
            IEnumerable<DateTime> stuff = calendarHolidays.SelectedDates;
            var sorted = stuff.OrderBy(u => u.Date);
            foreach (DateTime date in sorted)
            {
                labelSelectedDates.Text += date.ToLongDateString();
                labelSelectedDates.Text += "\n";
            }
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
