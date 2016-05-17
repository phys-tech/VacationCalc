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
            lHireDate.Text = "Принят: " + employee.HireDate.ToLongDateString();
            lAccountType.Text = employee.AccountType.GetRussianName();
            List<Vacation> list = employee.GetVacationsList();
            int number = 1;
            foreach (Vacation vacation in list)
            {
                object[] row = { number, vacation.StartDate, vacation.EndDate, vacation.Duration.Days};
                gridViewVacations.Rows.Add(row);
                number++;
            }
        }
    }
}
