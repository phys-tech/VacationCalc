using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

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
            EmploymentType type = (EmploymentType) Enum.Parse(typeof(EmploymentType), e.Row.Cells["colAccType"].Value.ToString());
            employeeManager.AddEmployee(name, date, type);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            employeeManager.LoadDataFromXml();
            GridViewComboBoxColumn column = gridViewEmployees.Columns["colAccType"] as GridViewComboBoxColumn;

            EmploymentTypeList temp = new EmploymentTypeList();
            column.DataSource = temp.GetDataList();
            column.ValueMember = "iValue";
            column.DisplayMember = "sDisplay";
            
            Dictionary<int, Employee> employees = employeeManager.GetAllEmployees();
            foreach (var emp in employees.Values)
            {
                string name = emp.GetName();
                DateTime date = emp.GetHireDate();
                EmploymentType type = emp.GetAccountType();
                int vacation = emp.GetVacationDaysLeft();
                object[] row = { name, date, type, vacation};
                gridViewEmployees.Rows.Add(row);
            }
        }
    }
}
