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
        private Employee employee;

        public AddVacationForm(Employee _employee, Point position)
        {
            employee = _employee;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = position;
            InitializeComponent();
        }

        private void calendarDates_SelectionChanged(object sender, EventArgs e)
        {
            DateTime currentSelection = calendarDates.SelectedDate;
            var dates = calendarDates.SelectedDates;
            if (dates.Count == 2)
            {
                DateTime start = (dates[0] < dates[1]) ? (dates[0]) : (dates[1]);
                DateTime end = (dates[0] < dates[1]) ? (dates[1]) : (dates[0]);
                int duration = employee.CreateProperVacation(new Vacation(start, end, ref employee.holidayManager)).Duration.Days;
                tbDuration.Text = duration.ToString();
            }
            else if (dates.Count > 2)
            {
                calendarDates.SelectedDates.Clear();
                calendarDates.SelectedDate = currentSelection;
                tbDuration.Text = "";
            }
            else if (dates.Count == 0)
                tbDuration.Text = "";
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (tbDuration.Text == "")
            {
                MessageBox.Show("Введите значение продолжительности отпуска", "Ошибка");
                return;
            }

            Vacation vacation;
            if (calendarDates.SelectedDates.Count == 2)
                vacation = new Vacation(calendarDates.SelectedDates[0], calendarDates.SelectedDates[1], ref employee.holidayManager);
            else
                vacation = new Vacation(int.Parse(tbDuration.Text), ref employee.holidayManager);

            bool valid = employee.AddVacation(vacation);
            if (!valid)
            {
                MessageBox.Show("Даты отпуска пересекаются с уже существующим отпуском", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void tbDuration_TextChanged(object sender, EventArgs e)
        {
            // reset the value, if user tries to enter some symbols instead of numbers
            string text = tbDuration.Text;
            int value;
            if ( !int.TryParse(text, out value) )
                tbDuration.Text = "";
        }

        private void tbDuration_Enter(object sender, EventArgs e)
        {
            // we may clear info here
            calendarDates.SelectedDates.Clear();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
