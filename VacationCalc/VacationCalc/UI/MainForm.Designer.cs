namespace VacationCalc
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject1 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn4 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.statusNumOfEmloyees = new Telerik.WinControls.UI.RadLabelElement();
            this.statusOnVacation = new Telerik.WinControls.UI.RadLabelElement();
            this.pageView = new Telerik.WinControls.UI.RadPageView();
            this.pageWorkers = new Telerik.WinControls.UI.RadPageViewPage();
            this.gridViewEmployees = new Telerik.WinControls.UI.RadGridView();
            this.pageFired = new Telerik.WinControls.UI.RadPageViewPage();
            this.gridViewFired = new Telerik.WinControls.UI.RadGridView();
            this.menuHolidaysCalendar = new Telerik.WinControls.UI.RadMenuItem();
            this.menuMain = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageView)).BeginInit();
            this.pageView.SuspendLayout();
            this.pageWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees.MasterTemplate)).BeginInit();
            this.pageFired.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFired.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.statusNumOfEmloyees,
            this.statusOnVacation});
            this.statusStrip.Location = new System.Drawing.Point(0, 542);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(951, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "radStatusStrip1";
            // 
            // statusNumOfEmloyees
            // 
            this.statusNumOfEmloyees.AccessibleDescription = "statusLabel";
            this.statusNumOfEmloyees.AccessibleName = "statusLabel";
            this.statusNumOfEmloyees.Name = "statusNumOfEmloyees";
            this.statusStrip.SetSpring(this.statusNumOfEmloyees, false);
            this.statusNumOfEmloyees.Text = "NumberOfEmpl";
            this.statusNumOfEmloyees.TextWrap = true;
            this.statusNumOfEmloyees.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // statusOnVacation
            // 
            this.statusOnVacation.AccessibleDescription = "statusLabel2";
            this.statusOnVacation.AccessibleName = "statusLabel2";
            this.statusOnVacation.Name = "statusOnVacation";
            this.statusStrip.SetSpring(this.statusOnVacation, false);
            this.statusOnVacation.Text = "NumberOfOnVacation";
            this.statusOnVacation.TextWrap = true;
            this.statusOnVacation.ToolTipText = "WTF man";
            this.statusOnVacation.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // pageView
            // 
            this.pageView.Controls.Add(this.pageWorkers);
            this.pageView.Controls.Add(this.pageFired);
            this.pageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageView.Location = new System.Drawing.Point(0, 20);
            this.pageView.Name = "pageView";
            this.pageView.SelectedPage = this.pageWorkers;
            this.pageView.Size = new System.Drawing.Size(951, 522);
            this.pageView.TabIndex = 4;
            this.pageView.Text = "radPageView1";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageView.GetChildAt(0))).StripScrollingAnimation = Telerik.WinControls.RadEasingType.InOutQuad;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).Enabled = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // pageWorkers
            // 
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.pageWorkers.Controls.Add(this.gridViewEmployees);
            this.pageWorkers.Location = new System.Drawing.Point(10, 37);
            this.pageWorkers.Name = "pageWorkers";
            this.pageWorkers.Size = new System.Drawing.Size(930, 474);
            this.pageWorkers.Text = "Работающие";
            // 
            // gridViewEmployees
            // 
            this.gridViewEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gridViewEmployees.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridViewEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewEmployees.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridViewEmployees.ForeColor = System.Drawing.Color.Black;
            this.gridViewEmployees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridViewEmployees.Location = new System.Drawing.Point(0, 0);
            // 
            // gridViewEmployees
            // 
            this.gridViewEmployees.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridViewEmployees.MasterTemplate.AutoGenerateColumns = false;
            this.gridViewEmployees.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "colID";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "ФИО";
            gridViewTextBoxColumn2.Name = "colName";
            gridViewTextBoxColumn2.Width = 199;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FilteringMode = Telerik.WinControls.UI.GridViewTimeFilteringMode.Date;
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn1.FormatString = "{0:D}";
            gridViewDateTimeColumn1.HeaderText = "Дата приема";
            gridViewDateTimeColumn1.Name = "colHireDate";
            gridViewDateTimeColumn1.Width = 95;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.HeaderText = "Тип занятости";
            gridViewComboBoxColumn1.Name = "colAccType";
            gridViewComboBoxColumn1.Width = 113;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "Кол-во оставшихся дней отпуска";
            gridViewTextBoxColumn3.Name = "colVacationLeft";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn3.Width = 210;
            conditionalFormattingObject1.CellBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject1.CellForeColor = System.Drawing.Color.Red;
            conditionalFormattingObject1.ConditionType = Telerik.WinControls.UI.ConditionTypes.GreaterOrEqual;
            conditionalFormattingObject1.Name = "NotSet";
            conditionalFormattingObject1.RowBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject1.RowForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject1.TValue1 = "1.01.2000";
            gridViewDateTimeColumn2.ConditionalFormattingObjectList.Add(conditionalFormattingObject1);
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn2.FormatString = "{0:dd.MM.yyyy}";
            gridViewDateTimeColumn2.HeaderText = "День рождения";
            gridViewDateTimeColumn2.Name = "colBirthDate";
            gridViewDateTimeColumn2.Width = 107;
            gridViewCommandColumn1.DefaultText = "Добавить...";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Отпуск";
            gridViewCommandColumn1.Name = "colAddVacation";
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 78;
            gridViewCommandColumn2.DefaultText = "Просмотр";
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "Инфо";
            gridViewCommandColumn2.Name = "colView";
            gridViewCommandColumn2.UseDefaultText = true;
            gridViewCommandColumn2.Width = 113;
            this.gridViewEmployees.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn3,
            gridViewDateTimeColumn2,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            sortDescriptor1.PropertyName = "colVacationLeft";
            this.gridViewEmployees.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gridViewEmployees.Name = "gridViewEmployees";
            this.gridViewEmployees.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell;
            this.gridViewEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridViewEmployees.Size = new System.Drawing.Size(930, 474);
            this.gridViewEmployees.TabIndex = 1;
            this.gridViewEmployees.UserAddingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.gridViewEmployees_UserAddingRow);
            this.gridViewEmployees.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.gridViewEmployees_UserDeletingRow);
            this.gridViewEmployees.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridViewEmployees_CellValueChanged);
            this.gridViewEmployees.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
            // 
            // pageFired
            // 
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.pageFired.Controls.Add(this.gridViewFired);
            this.pageFired.Location = new System.Drawing.Point(10, 37);
            this.pageFired.Name = "pageFired";
            this.pageFired.Size = new System.Drawing.Size(778, 474);
            this.pageFired.Text = "Уволенные";
            // 
            // gridViewFired
            // 
            this.gridViewFired.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gridViewFired.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridViewFired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewFired.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridViewFired.ForeColor = System.Drawing.Color.Black;
            this.gridViewFired.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridViewFired.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridViewFired.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridViewFired.MasterTemplate.AutoGenerateColumns = false;
            this.gridViewFired.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "ID";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "colID";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "ФИО";
            gridViewTextBoxColumn5.Name = "colName";
            gridViewTextBoxColumn5.Width = 189;
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FilteringMode = Telerik.WinControls.UI.GridViewTimeFilteringMode.Date;
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn3.FormatString = "{0:D}";
            gridViewDateTimeColumn3.HeaderText = "Дата приема";
            gridViewDateTimeColumn3.Name = "colHireDate";
            gridViewDateTimeColumn3.Width = 103;
            gridViewComboBoxColumn2.EnableExpressionEditor = false;
            gridViewComboBoxColumn2.HeaderText = "Тип занятости";
            gridViewComboBoxColumn2.Name = "colAccType";
            gridViewComboBoxColumn2.Width = 81;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "Кол-во оставшихся дней отпуска";
            gridViewTextBoxColumn6.Name = "colVacationLeft";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 160;
            gridViewCommandColumn3.DefaultText = "Добавить...";
            gridViewCommandColumn3.EnableExpressionEditor = false;
            gridViewCommandColumn3.HeaderText = "Отпуск";
            gridViewCommandColumn3.Name = "colAddVacation";
            gridViewCommandColumn3.UseDefaultText = true;
            gridViewCommandColumn3.Width = 61;
            gridViewCommandColumn4.DefaultText = "Просмотр";
            gridViewCommandColumn4.EnableExpressionEditor = false;
            gridViewCommandColumn4.HeaderText = "Инфо";
            gridViewCommandColumn4.Name = "colView";
            gridViewCommandColumn4.UseDefaultText = true;
            this.gridViewFired.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn3,
            gridViewComboBoxColumn2,
            gridViewTextBoxColumn6,
            gridViewCommandColumn3,
            gridViewCommandColumn4});
            sortDescriptor2.PropertyName = "colButton";
            this.gridViewFired.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.gridViewFired.Name = "gridViewFired";
            this.gridViewFired.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell;
            this.gridViewFired.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridViewFired.Size = new System.Drawing.Size(778, 474);
            this.gridViewFired.TabIndex = 1;
            this.gridViewFired.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
            // 
            // menuHolidaysCalendar
            // 
            this.menuHolidaysCalendar.AccessibleDescription = "Календарь выходных";
            this.menuHolidaysCalendar.AccessibleName = "Календарь выходных";
            this.menuHolidaysCalendar.Name = "menuHolidaysCalendar";
            this.menuHolidaysCalendar.Text = "Календарь выходных";
            this.menuHolidaysCalendar.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.menuHolidaysCalendar.Click += new System.EventHandler(this.menuHolidaysCalendar_Click);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuHolidaysCalendar});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(951, 20);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "radMenu1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 566);
            this.Controls.Add(this.pageView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Расчет отпусков";
            this.ThemeName = "ControlDefault";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageView)).EndInit();
            this.pageView.ResumeLayout(false);
            this.pageWorkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).EndInit();
            this.pageFired.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFired.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip statusStrip;
        private Telerik.WinControls.UI.RadLabelElement statusNumOfEmloyees;
        private Telerik.WinControls.UI.RadLabelElement statusOnVacation;
        private Telerik.WinControls.UI.RadPageView pageView;
        private Telerik.WinControls.UI.RadPageViewPage pageWorkers;
        private Telerik.WinControls.UI.RadGridView gridViewEmployees;
        private Telerik.WinControls.UI.RadPageViewPage pageFired;
        private Telerik.WinControls.UI.RadGridView gridViewFired;
        private Telerik.WinControls.UI.RadMenuItem menuHolidaysCalendar;
        private Telerik.WinControls.UI.RadMenu menuMain;

    }
}
