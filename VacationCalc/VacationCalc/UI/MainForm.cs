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
            statusLabel.Text = "Всего сотрудников: " + employeeManager.NumberOfEmployees();
            statusLabel2.Text = "В отпуске: " + employeeManager.NumberOfEmployeesOnVacation();
        }

        private void UpdateVacationDays(int employeeID, int rowIndex)
        {
            int vacationLeft = employeeManager.GetEmployee(employeeID).GetVacationDaysLeft();
            gridViewEmployees.Rows[rowIndex].Cells["colVacationLeft"].Value = vacationLeft;
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
            e.Row.Cells["colID"].Value = id;
            UpdateVacationDays(id, e.Row.Index);
            UpdateStatusStrip();
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

            UpdateVacationDays(id, e.RowIndex);
        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            int row = (sender as GridCommandCellElement).RowIndex;
            int id = int.Parse(gridViewEmployees.Rows[row].Cells["colID"].Value.ToString());
            Point startPosition = this.Location;
            startPosition.X += this.Width;
            AddVacationForm addVacation = new AddVacationForm(employeeManager.GetEmployee(id), startPosition);
            DialogResult dr = addVacation.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                UpdateVacationDays(id, row);
                UpdateStatusStrip();
            }
        }

        private void bDetailedView_Click(object sender, EventArgs e)
        {
            int row = gridViewEmployees.SelectedRows[0].Index;
            int id = int.Parse(gridViewEmployees.Rows[row].Cells["colID"].Value.ToString());
            Employee emp = employeeManager.GetEmployee(id);
            EmployeeDetailedView view = new EmployeeDetailedView(emp);
            DialogResult dr = view.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                UpdateVacationDays(id, row);
                UpdateStatusStrip();
            }
        }

    }
}
