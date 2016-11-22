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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn3 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn5 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject3 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.GridViewMaskBoxColumn gridViewMaskBoxColumn2 = new Telerik.WinControls.UI.GridViewMaskBoxColumn();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject4 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn5 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn6 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn6 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn4 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn7 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn8 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor4 = new Telerik.WinControls.Data.SortDescriptor();
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
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageView.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).Enabled = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
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
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.HeaderText = "ID";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "colID";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.HeaderText = "ФИО";
            gridViewTextBoxColumn8.Name = "colName";
            gridViewTextBoxColumn8.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn8.Width = 184;
            gridViewDateTimeColumn4.EnableExpressionEditor = false;
            gridViewDateTimeColumn4.FilteringMode = Telerik.WinControls.UI.GridViewTimeFilteringMode.Date;
            gridViewDateTimeColumn4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn4.FormatString = "{0:D}";
            gridViewDateTimeColumn4.HeaderText = "Дата приема";
            gridViewDateTimeColumn4.Name = "colHireDate";
            gridViewDateTimeColumn4.Width = 87;
            gridViewComboBoxColumn3.EnableExpressionEditor = false;
            gridViewComboBoxColumn3.HeaderText = "Тип занятости";
            gridViewComboBoxColumn3.Name = "colAccType";
            gridViewComboBoxColumn3.Width = 104;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.HeaderText = "Кол-во оставшихся дней отпуска";
            gridViewTextBoxColumn9.Name = "colVacationLeft";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.Width = 196;
            conditionalFormattingObject3.CellBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject3.CellForeColor = System.Drawing.Color.Red;
            conditionalFormattingObject3.ConditionType = Telerik.WinControls.UI.ConditionTypes.GreaterOrEqual;
            conditionalFormattingObject3.Name = "BirthdayNotSet";
            conditionalFormattingObject3.RowBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject3.RowForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject3.TValue1 = "1.01.2000";
            gridViewDateTimeColumn5.ConditionalFormattingObjectList.Add(conditionalFormattingObject3);
            gridViewDateTimeColumn5.EnableExpressionEditor = false;
            gridViewDateTimeColumn5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn5.FormatString = "{0:dd.MM.yyyy}";
            gridViewDateTimeColumn5.HeaderText = "День рождения";
            gridViewDateTimeColumn5.Name = "colBirthDate";
            gridViewDateTimeColumn5.Width = 99;
            conditionalFormattingObject4.CellBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject4.CellForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            conditionalFormattingObject4.Name = "MobileNotSet";
            conditionalFormattingObject4.RowBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject4.RowForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject4.TValue1 = "0000";
            gridViewMaskBoxColumn2.ConditionalFormattingObjectList.Add(conditionalFormattingObject4);
            gridViewMaskBoxColumn2.EnableExpressionEditor = false;
            gridViewMaskBoxColumn2.FieldName = "Мобильный";
            gridViewMaskBoxColumn2.HeaderText = "Мобильный";
            gridViewMaskBoxColumn2.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            gridViewMaskBoxColumn2.Name = "colMobile";
            gridViewMaskBoxColumn2.Width = 93;
            gridViewCommandColumn5.DefaultText = "Добавить...";
            gridViewCommandColumn5.EnableExpressionEditor = false;
            gridViewCommandColumn5.HeaderText = "Отпуск";
            gridViewCommandColumn5.Name = "colAddVacation";
            gridViewCommandColumn5.UseDefaultText = true;
            gridViewCommandColumn5.Width = 63;
            gridViewCommandColumn6.DefaultText = "Просмотр";
            gridViewCommandColumn6.EnableExpressionEditor = false;
            gridViewCommandColumn6.HeaderText = "Инфо";
            gridViewCommandColumn6.Name = "colView";
            gridViewCommandColumn6.UseDefaultText = true;
            gridViewCommandColumn6.Width = 90;
            this.gridViewEmployees.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewDateTimeColumn4,
            gridViewComboBoxColumn3,
            gridViewTextBoxColumn9,
            gridViewDateTimeColumn5,
            gridViewMaskBoxColumn2,
            gridViewCommandColumn5,
            gridViewCommandColumn6});
            sortDescriptor3.PropertyName = "colName";
            this.gridViewEmployees.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
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
            this.pageFired.Size = new System.Drawing.Size(930, 474);
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
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.HeaderText = "ID";
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "colID";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.HeaderText = "ФИО";
            gridViewTextBoxColumn11.Name = "colName";
            gridViewTextBoxColumn11.Width = 268;
            gridViewDateTimeColumn6.EnableExpressionEditor = false;
            gridViewDateTimeColumn6.FilteringMode = Telerik.WinControls.UI.GridViewTimeFilteringMode.Date;
            gridViewDateTimeColumn6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn6.FormatString = "{0:D}";
            gridViewDateTimeColumn6.HeaderText = "Дата приема";
            gridViewDateTimeColumn6.Name = "colHireDate";
            gridViewDateTimeColumn6.Width = 146;
            gridViewComboBoxColumn4.EnableExpressionEditor = false;
            gridViewComboBoxColumn4.HeaderText = "Тип занятости";
            gridViewComboBoxColumn4.Name = "colAccType";
            gridViewComboBoxColumn4.Width = 115;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.HeaderText = "Кол-во оставшихся дней отпуска";
            gridViewTextBoxColumn12.Name = "colVacationLeft";
            gridViewTextBoxColumn12.ReadOnly = true;
            gridViewTextBoxColumn12.Width = 227;
            gridViewCommandColumn7.DefaultText = "Добавить...";
            gridViewCommandColumn7.EnableExpressionEditor = false;
            gridViewCommandColumn7.HeaderText = "Отпуск";
            gridViewCommandColumn7.Name = "colAddVacation";
            gridViewCommandColumn7.UseDefaultText = true;
            gridViewCommandColumn7.Width = 87;
            gridViewCommandColumn8.DefaultText = "Просмотр";
            gridViewCommandColumn8.EnableExpressionEditor = false;
            gridViewCommandColumn8.HeaderText = "Инфо";
            gridViewCommandColumn8.Name = "colView";
            gridViewCommandColumn8.UseDefaultText = true;
            gridViewCommandColumn8.Width = 71;
            this.gridViewFired.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewDateTimeColumn6,
            gridViewComboBoxColumn4,
            gridViewTextBoxColumn12,
            gridViewCommandColumn7,
            gridViewCommandColumn8});
            sortDescriptor4.PropertyName = "colButton";
            this.gridViewFired.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor4});
            this.gridViewFired.Name = "gridViewFired";
            this.gridViewFired.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell;
            this.gridViewFired.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridViewFired.Size = new System.Drawing.Size(930, 474);
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
