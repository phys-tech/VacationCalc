using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using VacationCalc.Model;

namespace VacationCalc
{
    public partial class AddVacationForm : Telerik.WinControls.UI.RadForm
    {
        public AddVacationForm()
        {
            InitializeComponent();
        }

        private void calStartDate_SelectionChanged(object sender, EventArgs e)
        {
            //DateTime date = calendarDates.SelectedDate;
            var dates = calendarDates.SelectedDates;
            if (dates.Count == 2)
            {
                //string date1 = dates[0].ToShortDateString();
                //string date2 = dates[1].ToShortDateString();
                //MessageBox.Show("Selection changed " + date1 + " " + date2);
                TimeSpan span = dates[0] - dates[1];
                span = span.Duration();
                tbDuration.Text = span.Days.ToString();                
            }
            else if (dates.Count > 2)
                calendarDates.SelectedDates.Clear();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            Vacation vacation;
            this.Close();
        }
    }
}
