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
    public partial class EmployeeDetailedView : Telerik.WinControls.UI.RadForm
    {
        private Employee employee;
        public EmployeeDetailedView(Employee _employee)
        {
            employee = _employee;
            InitializeComponent();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeDetailedView_Load(object sender, EventArgs e)
        {
            lEmployeeName.Text = employee.Name;
            comBarLabelHireDate.Text = "Принят: " + employee.HireDate.ToLongDateString();
            comBarLabelType.Text = employee.AccountType.GetRussianName();
            UpdateVacationInfo();

            List<Vacation> list = employee.GetVacationsList();
            int number = 1;
            foreach (Vacation vacation in list)
            {
                object[] row;
                if (vacation.IsDateDefined)
                    row = new object[4] { number, vacation.StartDate, vacation.EndDate, vacation.Duration.Days };
                else
                    row = new object[4] { number, null, null, vacation.Duration.Days };
                gridViewVacations.Rows.Add(row);
                number++;
            }
        }

        private void UpdateVacationInfo()
        {
            comBarLabelTotalVacation.Text = "Дней отпуска всего: " + employee.TotalVacationDays.ToString();
            comBarLabelVacationSpent.Text = "Отгуляно: " + employee.VacationDaysSpent();
            comBarLabelVacationLeft.Text = "Осталось: " + employee.VacationDaysLeft;
            lOnVacation.Visible = employee.IsOnVacation();
        }

        private void gridViewVacations_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            Vacation vacation;
            if (e.Rows[0].Cells["colStartDate"].Value != null)
            {
                DateTime start = (DateTime)e.Rows[0].Cells["colStartDate"].Value;
                DateTime end = (DateTime)e.Rows[0].Cells["colEndDate"].Value;
                vacation = new Vacation(start, end);
            }
            else
            {
                int duration = int.Parse(e.Rows[0].Cells["colDuration"].Value.ToString());
                vacation = new Vacation(duration);
            }
            employee.DeleteVacation(vacation);
            UpdateVacationInfo();
        }

    }
}
