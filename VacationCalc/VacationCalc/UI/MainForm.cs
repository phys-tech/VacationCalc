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
        private bool saveOnExit;
        

        public MainForm()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RadGridLocalizationProvider.CurrentProvider = new RussianGridViewLocalization();
            saveOnExit = employeeManager.LoadDataFromXml();
            GridViewComboBoxColumn column = gridViewEmployees.Columns["colAccType"] as GridViewComboBoxColumn;

            EmploymentTypeList temp = new EmploymentTypeList();
            column.DataSource = temp.GetDataList();
            column.ValueMember = "iValue";
            column.DisplayMember = "sDisplay";

            UpdateGrids();
            UpdateStatusStrip();
            //SetDateTimePicker();
            if (!saveOnExit)
                MessageBox.Show("Произошла ошибка при загрузке данных. Данные не будут сохранены при окончании работы, обратитесь в техподдержку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateGrids()
        {
            gridViewFired.Rows.Clear();
            gridViewEmployees.Rows.Clear();
            Dictionary<int, Employee> employees = employeeManager.GetAllEmployees();
            foreach (int empID in employees.Keys)
            {
                Employee emp = employees[empID];
                string name = emp.Name;
                DateTime date = emp.HireDate;
                EmploymentType type = emp.AccountType;
                int vacation = emp.GetVacationDaysLeft();
                DateTime birth = emp.BirthDate;
                string mobile = emp.MobilePhone;
                object[] row = { empID, name, date, type, vacation, birth, mobile };
                if (!emp.IsFired)
                    gridViewEmployees.Rows.Add(row);
                else
                    gridViewFired.Rows.Add(row);
            }        
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
                DateTime birthday = (DateTime)e.Rows[0].Cells["colBirthDate"].Value;
                string mobile = e.Rows[0].Cells["colMobile"].Value.ToString();
                int id = employeeManager.AddEmployee(name, date, type, birthday, mobile);
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
            // if column is read-only it means we had changed it programatically, no need for firing an event
            if (e.Column.ReadOnly)
                return;
            
            int id = int.Parse(e.Row.Cells["colID"].Value.ToString());
            if (e.Column.Name == "colName")
                employeeManager.ChangeName(id, e.Value.ToString());
            else if (e.Column.Name == "colHireDate")
                employeeManager.ChangeHireDate(id, (DateTime)e.Value);
            else if (e.Column.Name == "colAccType")
                employeeManager.ChangeType(id, (EmploymentType)Enum.Parse(typeof(EmploymentType), e.Value.ToString()));
            else if (e.Column.Name == "colBirthDate")
                employeeManager.ChangeBirthday(id, (DateTime)e.Value);
            else if (e.Column.Name == "colMobile")
                employeeManager.ChangeMobilePhone(id, e.Value.ToString());

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
                UpdateGrids();
                UpdateStatusStrip();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (saveOnExit)
                employeeManager.SaveDataToXML();
        }

        private void menuHolidaysCalendar_Click(object sender, EventArgs e)
        {
            HolidaysForm holidays = new HolidaysForm();
            holidays.Show();
        }

        private void menuPrintMobiles_Click(object sender, EventArgs e)
        {
            printDocumentRad = new RadPrintDocument();
            printDocumentRad.DefaultPageSettings.Landscape = false;
            printDocumentRad.AssociatedObject = this.gridViewEmployees;
            printDocumentRad.MiddleHeader = "Список телефонов сотрудников офиса Фастдев, Екатеринбург";
            printDocumentRad.HeaderFont = new System.Drawing.Font(FontFamily.GenericSerif, 15.0F);
            printDocumentRad.LeftFooter = "Число сотрудников: " + employeeManager.NumberOfEmployees();

            ShowColumns(false, true);
            RadPrintPreviewDialog dialog = new RadPrintPreviewDialog();
            dialog.Document = printDocumentRad;
            dialog.ShowDialog();
            ShowColumns(true, true);
            gridViewEmployees.BestFitColumns(BestFitColumnMode.DisplayedCells);
        }

        private void menuPrintBirthdates_Click(object sender, EventArgs e)
        {
            printDocumentRad = new RadPrintDocument();
            printDocumentRad.DefaultPageSettings.Landscape = false;
            printDocumentRad.AssociatedObject = this.gridViewEmployees;
            printDocumentRad.MiddleHeader = "Список дней рожденья сотрудников офиса Фастдев, Екатеринбург";
            printDocumentRad.HeaderFont = new System.Drawing.Font(FontFamily.GenericSerif, 15.0F);
            printDocumentRad.LeftFooter = "Число сотрудников: " + employeeManager.NumberOfEmployees();

            ShowColumns(false, false);
            RadPrintPreviewDialog dialog = new RadPrintPreviewDialog();
            dialog.Document = printDocumentRad;
            dialog.ShowDialog();
            ShowColumns(true, false);
            gridViewEmployees.BestFitColumns(BestFitColumnMode.DisplayedCells);
        }

        private void ShowColumns(bool visibility, bool mobile)
        {
            gridViewEmployees.Columns["colHireDate"].IsVisible = visibility;
            gridViewEmployees.Columns["colAccType"].IsVisible = visibility;
            gridViewEmployees.Columns["colVacationLeft"].IsVisible = visibility;
            gridViewEmployees.Columns["colView"].IsVisible = visibility;
            gridViewEmployees.Columns["colAddVacation"].IsVisible = visibility;

            gridViewEmployees.Columns["colMobile"].IsVisible = visibility || mobile;
            gridViewEmployees.Columns["colBirthDate"].IsVisible = visibility || !mobile;
        }


        /*
        private void SetDateTimePicker()
        {
            var column = gridViewEmployees.Columns["colBirthDate"];
            var editor = column.GetDefaultEditor();
            var stuff = ((RadDateTimeEditor)editor);
            var elem = stuff.EditorElement;
            var cal = (RadDateTimePickerElement)elem;
            //cal.BorderThickness.All = 4;
            cal.ShowCurrentTime = false;

            
            editor.Validate();
            editor.Initialize(gridViewEmployees, editor);

            //editor.Validate();
            //MessageBox.Show(editor.ToString());
            

        }*/

    }
}
