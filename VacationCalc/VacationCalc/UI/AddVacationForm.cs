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
        private int EmployeeID;
        private EmployeeManager EmpManager;

        public AddVacationForm()
        {
            InitializeComponent();
        }

        public AddVacationForm(EmployeeManager manager, int employeeID)
        {
            EmpManager = manager;
            EmployeeID = employeeID;
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
            {
                calendarDates.SelectedDates.RemoveRange(2, 1);
                //calendarDates.SelectedDates.Clear();
            }
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (tbDuration.Text == "")
            {
                MessageBox.Show("Введите значение продолжительности отпуска");
                return;
            }
            Vacation vacation = new Vacation(int.Parse(tbDuration.Text));
            EmpManager.AddVacation(EmployeeID, vacation);
            this.Close();
        }

        private void tbDuration_TextChanged(object sender, EventArgs e)
        {
            // reset the value, if user tries to enter so symbols instead of numbers
            string text = tbDuration.Text;
            int value;
            if ( !int.TryParse(text, out value) )
                tbDuration.Text = "";
        }

        private void tbDuration_Enter(object sender, EventArgs e)
        {
            // we may clear info here
            //MessageBox.Show("Enter textbox ");
        }
    }
}
