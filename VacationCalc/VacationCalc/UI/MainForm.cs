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

        private void MainForm_Load(object sender, EventArgs e)
        {
            employeeManager.LoadDataFromXml();
            GridViewComboBoxColumn column = gridViewEmployees.Columns["colAccType"] as GridViewComboBoxColumn;

            EmploymentTypeList temp = new EmploymentTypeList();
            column.DataSource = temp.GetDataList();
            column.ValueMember = "iValue";
            column.DisplayMember = "sDisplay";

            Dictionary<int, Employee> employees = employeeManager.GetAllEmployees();
            foreach (int empID in employees.Keys)
            {
                Employee emp = employees[empID];
                string name = emp.Name;
                DateTime date = emp.HireDate;
                EmploymentType type = emp.AccountType;
                int vacation = emp.GetVacationDaysLeft();
                object[] row = { empID, name, date, type, vacation };
                gridViewEmployees.Rows.Add(row);
            }
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
            int id = employeeManager.AddEmployee(name, date, type);
            int vacation = employeeManager.GetEmployee(id).GetVacationDaysLeft();
            e.Row.Cells["colVacationLeft"].Value = vacation;
        }

        private void gridViewEmployees_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            int id = int.Parse( e.Row.Cells["colID"].Value.ToString()) ;
            //MessageBox.Show("ID changed = " + id.ToString());
            if (e.Column.Name == "colName")
                employeeManager.ChangeName(id, e.Value.ToString());
            else if (e.Column.Name == "colHireDate")
                employeeManager.ChangeDate(id, (DateTime) e.Value);
            else if (e.Column.Name == "colAccType")
                employeeManager.ChangeType(id, (EmploymentType) Enum.Parse(typeof(EmploymentType), e.Value.ToString()));
        }

    }
}
