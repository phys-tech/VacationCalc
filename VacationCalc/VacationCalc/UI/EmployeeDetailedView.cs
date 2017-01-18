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
            comBarLabelBirthday.Text = "День рождения: " + employee.BirthDate.ToShortDateString();
            comBarLabelMobile.Text = "Мобильный: " + employee.MobilePhone;
            UpdateContract();
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
            comBarLabelTotalVacation.Text = "Дней отпуска всего: " + employee.calculator.TotalVacationDays.ToString();
            comBarLabelVacationSpent.Text = "Отгуляно: " + employee.calculator.VacationDaysSpent;
            comBarLabelVacationLeft.Text = "Осталось: " + employee.calculator.VacationDaysLeft;
            lOnVacation.Visible = employee.IsOnVacation();
        }

        private void UpdateContract()
        {
            lFired.Visible = employee.IsFired;
            if (employee.IsFired)
                bFireHire.Text = "Принять";
            else
                bFireHire.Text = "Уволить";
        }

        private void gridViewVacations_UserAddingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            if (e.Rows[0].Cells["colEndDate"].Value != null && e.Rows[0].Cells["colStartDate"].Value != null)
            {
                DateTime start = (DateTime)e.Rows[0].Cells["colStartDate"].Value;
                DateTime end = (DateTime)e.Rows[0].Cells["colEndDate"].Value;
                Vacation newVacation = new Vacation(start, end, ref employee.holidayManager);
                if (!employee.AddVacation(newVacation))
                {
                    MessageBox.Show("Даты отпуска пересекаются с уже существующим отпуском", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                    UpdateVacationInfo();
            }
            else
            {
                MessageBox.Show("Заполните обе даты отпуска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void gridViewVacations_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            Vacation vacation;
            if (e.Rows[0].Cells["colStartDate"].Value != null)
            {
                DateTime start = (DateTime)e.Rows[0].Cells["colStartDate"].Value;
                DateTime end = (DateTime)e.Rows[0].Cells["colEndDate"].Value;
                vacation = new Vacation(start, end, ref employee.holidayManager);
            }
            else
            {
                int duration = int.Parse(e.Rows[0].Cells["colDuration"].Value.ToString());
                vacation = new Vacation(duration, ref employee.holidayManager);
            }
            employee.DeleteVacation(vacation);
            UpdateVacationInfo();
        }

        private void gridViewVacations_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if ( (e.Column.Name == "colStartDate" && e.Row.Cells["colEndDate"].Value != null) ||
                  (e.Column.Name == "colEndDate" && e.Row.Cells["colStartDate"].Value != null))
            {
                DateTime start = (DateTime)e.Row.Cells["colStartDate"].Value;
                DateTime end = (DateTime)e.Row.Cells["colEndDate"].Value;
                e.Row.Cells["colDuration"].Value = employee.CreateProperVacation(new Vacation(start, end, ref employee.holidayManager)).Duration.Days;
            }
        }

        private void gridViewVacations_CellEditorInitialized(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Column.Name == "colStartDate" && e.Row.Cells["colEndDate"].Value != null)
            {
                if (e.Value == null)
                    e.ActiveEditor.Value = ((DateTime)e.Row.Cells["colEndDate"].Value).AddDays(-5.0);
            }
            if (e.Column.Name == "colEndDate" && e.Row.Cells["colStartDate"].Value != null)
            {
                if (e.Value == null)
                    e.ActiveEditor.Value = ((DateTime)e.Row.Cells["colStartDate"].Value).AddDays(5.0);
            }
        }

        private void gridViewVacations_CellValidating(object sender, Telerik.WinControls.UI.CellValidatingEventArgs e)
        {
            if (e.OldValue != e.Value)
            {
                if (e.Row.Cells["colStartDate"].Value != null && e.Row.Cells["colEndDate"].Value != null)
                {
                    bool ok = true;
                    DateTime start = (DateTime)e.Row.Cells["colStartDate"].Value;
                    DateTime end = (DateTime)e.Row.Cells["colEndDate"].Value;
                    if (e.Column.Name == "colStartDate")
                    {
                        start = (DateTime)e.Value;
                        ok = employee.ChangeStartDate(start, end);
                    }
                    if (e.Column.Name == "colEndDate")
                    {
                        end = (DateTime)e.Value;
                        ok = employee.ChangeEndDate(start, end);
                    }

                    if (!ok)
                    {
                        MessageBox.Show("Даты отпуска пересекаются с уже существующим отпуском", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    UpdateVacationInfo();
                }
            }
        }

        private void bFireHire_Click(object sender, EventArgs e)
        {
            employee.IsFired = !employee.IsFired;
            UpdateContract();            
        }

    }
}
