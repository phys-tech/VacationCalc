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
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private EmployeeManager employeeManager;
        

        public MainForm()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            employeeManager.SaveDataToXML();
        }

        private void gridViewEmployees_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            string name = e.Row.Cells["colName"].Value.ToString();
            DateTime date = (DateTime) e.Row.Cells["colHireDate"].Value;
            employeeManager.AddEmployee(name, date, EmploymentType.IP);
        }
    }
}
