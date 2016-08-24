using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

using VacationCalc.Model;
using VacationCalc.UI;

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
            RadGridLocalizationProvider.CurrentProvider = new RussianGridViewLocalization();
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
            UpdateStatusStrip();
        }

        private void UpdateStatusStrip()
        {
            string empOnVacation;
            statusNumOfEmloyees.Text = "Всего сотрудников: " + employeeManager.NumberOfEmployees();
            statusOnVacation.Text = "В отпуске: " + employeeManager.NumberOfEmployeesOnVacation(out empOnVacation);
            statusOnVacation.ToolTipText = empOnVacation;
        }

        private void UpdateVacationDays(int employeeID, GridViewRowInfo row)
        {
            int vacationLeft = employeeManager.GetEmployee(employeeID).GetVacationDaysLeft();
            row.Cells["colVacationLeft"].Value = vacationLeft;
        }

        private void gridViewEmployees_UserAddingRow(object sender, GridViewRowCancelEventArgs e)
        {
            if (e.Rows[0].Cells["colName"].Value != null && e.Rows[0].Cells["colHireDate"].Value != null && e.Rows[0].Cells["colAccType"].Value != null)
            {
                string name = e.Rows[0].Cells["colName"].Value.ToString();
                DateTime date = (DateTime)e.Rows[0].Cells["colHireDate"].Value;
                EmploymentType type = (EmploymentType)Enum.Parse(typeof(EmploymentType), e.Rows[0].Cells["colAccType"].Value.ToString());
                int id = employeeManager.AddEmployee(name, date, type);
                e.Rows[0].Cells["colID"].Value = id;
                UpdateVacationDays(id, e.Rows[0]);
                UpdateStatusStrip();
            }
            else
            {
                MessageBox.Show("Заполните все данные о сотруднике!");
                e.Cancel = true;
            }
        }

        private void gridViewEmployees_UserDeletingRow(object sender, GridViewRowCancelEventArgs e)
        {
            int id = int.Parse(e.Rows[0].Cells["colID"].Value.ToString());
            employeeManager.DeleteEmployee(id);
            UpdateStatusStrip();
        }

        private void gridViewEmployees_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            // ID equals null only if we are adding new data, so no need for firing an event
            if (e.Row.Cells["colID"].Value == null)
                return;
            // if columns is read-only it means we had changed it programatically, no need for firing an event
            if (e.Column.ReadOnly)
                return;
            
            int id = int.Parse(e.Row.Cells["colID"].Value.ToString());
            if (e.Column.Name == "colName")
                employeeManager.ChangeName(id, e.Value.ToString());
            else if (e.Column.Name == "colHireDate")
                employeeManager.ChangeDate(id, (DateTime) e.Value);
            else if (e.Column.Name == "colAccType")
                employeeManager.ChangeType(id, (EmploymentType) Enum.Parse(typeof(EmploymentType), e.Value.ToString()));

            UpdateVacationDays(id, e.Row);
        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            var Row = (sender as GridCommandCellElement).RowInfo;
            var column = (sender as GridCommandCellElement).ColumnInfo;
            int id = int.Parse(Row.Cells["colID"].Value.ToString());
            Employee emp = employeeManager.GetEmployee(id);
            DialogResult result = DialogResult.Cancel;
            if (column.Name == "colView")
            {
                EmployeeDetailedView view = new EmployeeDetailedView(emp);
                result = view.ShowDialog();
            }
            else if (column.Name == "colAddVacation")
            {
                Point startPosition = this.Location;
                startPosition.X += this.Width;
                AddVacationForm addVacation = new AddVacationForm(emp, startPosition);
                result = addVacation.ShowDialog();
            }

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                UpdateVacationDays(id, Row);
                UpdateStatusStrip();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeeManager.SaveDataToXML();
        }

    }
}
