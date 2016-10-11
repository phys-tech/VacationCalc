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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn7 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn7 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn13 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn14 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor7 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn8 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn8 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn15 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn16 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor8 = new Telerik.WinControls.Data.SortDescriptor();
            this.menuItemTop = new Telerik.WinControls.UI.RadMenuItem();
            this.menuHolidaysCalendar = new Telerik.WinControls.UI.RadMenuItem();
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.statusNumOfEmloyees = new Telerik.WinControls.UI.RadLabelElement();
            this.statusOnVacation = new Telerik.WinControls.UI.RadLabelElement();
            this.pageView = new Telerik.WinControls.UI.RadPageView();
            this.pageWorkers = new Telerik.WinControls.UI.RadPageViewPage();
            this.gridViewEmployees = new Telerik.WinControls.UI.RadGridView();
            this.pageFired = new Telerik.WinControls.UI.RadPageViewPage();
            this.gridViewFired = new Telerik.WinControls.UI.RadGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItemTop
            // 
            this.menuItemTop.AccessibleDescription = "Меню";
            this.menuItemTop.AccessibleName = "Меню";
            this.menuItemTop.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuHolidaysCalendar});
            this.menuItemTop.Name = "menuItemTop";
            this.menuItemTop.Text = "Меню";
            this.menuItemTop.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // menuHolidaysCalendar
            // 
            this.menuHolidaysCalendar.AccessibleDescription = "menuHolidaysCalendar";
            this.menuHolidaysCalendar.AccessibleName = "menuHolidaysCalendar";
            this.menuHolidaysCalendar.Name = "menuHolidaysCalendar";
            this.menuHolidaysCalendar.Text = "Календарь выходных...";
            this.menuHolidaysCalendar.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.menuHolidaysCalendar.Click += new System.EventHandler(this.menuHolidaysCalendar_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.statusNumOfEmloyees,
            this.statusOnVacation});
            this.statusStrip.Location = new System.Drawing.Point(0, 542);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(799, 24);
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
            this.pageView.SelectedPage = this.pageFired;
            this.pageView.Size = new System.Drawing.Size(799, 522);
            this.pageView.TabIndex = 4;
            this.pageView.Text = "radPageView1";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageView.GetChildAt(0))).StripScrollingAnimation = Telerik.WinControls.RadEasingType.InOutQuad;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).Enabled = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.pageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // pageWorkers
            // 
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.pageWorkers.Controls.Add(this.gridViewEmployees);
            this.pageWorkers.Location = new System.Drawing.Point(10, 37);
            this.pageWorkers.Name = "pageWorkers";
            this.pageWorkers.Size = new System.Drawing.Size(778, 474);
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
            gridViewTextBoxColumn19.EnableExpressionEditor = false;
            gridViewTextBoxColumn19.HeaderText = "ID";
            gridViewTextBoxColumn19.IsVisible = false;
            gridViewTextBoxColumn19.Name = "colID";
            gridViewTextBoxColumn19.ReadOnly = true;
            gridViewTextBoxColumn20.EnableExpressionEditor = false;
            gridViewTextBoxColumn20.HeaderText = "ФИО";
            gridViewTextBoxColumn20.Name = "colName";
            gridViewTextBoxColumn20.Width = 224;
            gridViewDateTimeColumn7.EnableExpressionEditor = false;
            gridViewDateTimeColumn7.FilteringMode = Telerik.WinControls.UI.GridViewTimeFilteringMode.Date;
            gridViewDateTimeColumn7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn7.FormatString = "{0:D}";
            gridViewDateTimeColumn7.HeaderText = "Дата приема";
            gridViewDateTimeColumn7.Name = "colHireDate";
            gridViewDateTimeColumn7.Width = 122;
            gridViewComboBoxColumn7.EnableExpressionEditor = false;
            gridViewComboBoxColumn7.HeaderText = "Тип занятости";
            gridViewComboBoxColumn7.Name = "colAccType";
            gridViewComboBoxColumn7.Width = 96;
            gridViewTextBoxColumn21.EnableExpressionEditor = false;
            gridViewTextBoxColumn21.HeaderText = "Кол-во оставшихся дней отпуска";
            gridViewTextBoxColumn21.Name = "colVacationLeft";
            gridViewTextBoxColumn21.ReadOnly = true;
            gridViewTextBoxColumn21.Width = 189;
            gridViewCommandColumn13.DefaultText = "Добавить...";
            gridViewCommandColumn13.EnableExpressionEditor = false;
            gridViewCommandColumn13.HeaderText = "Отпуск";
            gridViewCommandColumn13.Name = "colAddVacation";
            gridViewCommandColumn13.UseDefaultText = true;
            gridViewCommandColumn13.Width = 72;
            gridViewCommandColumn14.DefaultText = "Просмотр";
            gridViewCommandColumn14.EnableExpressionEditor = false;
            gridViewCommandColumn14.HeaderText = "Инфо";
            gridViewCommandColumn14.Name = "colView";
            gridViewCommandColumn14.UseDefaultText = true;
            gridViewCommandColumn14.Width = 59;
            this.gridViewEmployees.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewDateTimeColumn7,
            gridViewComboBoxColumn7,
            gridViewTextBoxColumn21,
            gridViewCommandColumn13,
            gridViewCommandColumn14});
            sortDescriptor7.PropertyName = "colButton";
            this.gridViewEmployees.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor7});
            this.gridViewEmployees.Name = "gridViewEmployees";
            this.gridViewEmployees.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell;
            this.gridViewEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridViewEmployees.Size = new System.Drawing.Size(778, 474);
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
            // gridViewFired
            // 
            this.gridViewFired.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridViewFired.MasterTemplate.AutoGenerateColumns = false;
            this.gridViewFired.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn22.EnableExpressionEditor = false;
            gridViewTextBoxColumn22.HeaderText = "ID";
            gridViewTextBoxColumn22.IsVisible = false;
            gridViewTextBoxColumn22.Name = "colID";
            gridViewTextBoxColumn22.ReadOnly = true;
            gridViewTextBoxColumn23.EnableExpressionEditor = false;
            gridViewTextBoxColumn23.HeaderText = "ФИО";
            gridViewTextBoxColumn23.Name = "colName";
            gridViewTextBoxColumn23.Width = 224;
            gridViewDateTimeColumn8.EnableExpressionEditor = false;
            gridViewDateTimeColumn8.FilteringMode = Telerik.WinControls.UI.GridViewTimeFilteringMode.Date;
            gridViewDateTimeColumn8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn8.FormatString = "{0:D}";
            gridViewDateTimeColumn8.HeaderText = "Дата приема";
            gridViewDateTimeColumn8.Name = "colHireDate";
            gridViewDateTimeColumn8.Width = 122;
            gridViewComboBoxColumn8.EnableExpressionEditor = false;
            gridViewComboBoxColumn8.HeaderText = "Тип занятости";
            gridViewComboBoxColumn8.Name = "colAccType";
            gridViewComboBoxColumn8.Width = 96;
            gridViewTextBoxColumn24.EnableExpressionEditor = false;
            gridViewTextBoxColumn24.HeaderText = "Кол-во оставшихся дней отпуска";
            gridViewTextBoxColumn24.Name = "colVacationLeft";
            gridViewTextBoxColumn24.ReadOnly = true;
            gridViewTextBoxColumn24.Width = 189;
            gridViewCommandColumn15.DefaultText = "Добавить...";
            gridViewCommandColumn15.EnableExpressionEditor = false;
            gridViewCommandColumn15.HeaderText = "Отпуск";
            gridViewCommandColumn15.Name = "colAddVacation";
            gridViewCommandColumn15.UseDefaultText = true;
            gridViewCommandColumn15.Width = 72;
            gridViewCommandColumn16.DefaultText = "Просмотр";
            gridViewCommandColumn16.EnableExpressionEditor = false;
            gridViewCommandColumn16.HeaderText = "Инфо";
            gridViewCommandColumn16.Name = "colView";
            gridViewCommandColumn16.UseDefaultText = true;
            gridViewCommandColumn16.Width = 59;
            this.gridViewFired.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewDateTimeColumn8,
            gridViewComboBoxColumn8,
            gridViewTextBoxColumn24,
            gridViewCommandColumn15,
            gridViewCommandColumn16});
            sortDescriptor8.PropertyName = "colButton";
            this.gridViewFired.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor8});
            this.gridViewFired.Name = "gridViewFired";
            this.gridViewFired.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell;
            this.gridViewFired.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridViewFired.Size = new System.Drawing.Size(778, 474);
            this.gridViewFired.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 566);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuItemTop});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(799, 20);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "radMenu1";
            this.Controls.Add(this.pageView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuMain);
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

        private Telerik.WinControls.UI.RadMenuItem menuItemTop;
        private Telerik.WinControls.UI.RadStatusStrip statusStrip;
        private Telerik.WinControls.UI.RadLabelElement statusNumOfEmloyees;
        private Telerik.WinControls.UI.RadLabelElement statusOnVacation;
        private Telerik.WinControls.UI.RadMenuItem menuHolidaysCalendar;
        private Telerik.WinControls.UI.RadPageView pageView;
        private Telerik.WinControls.UI.RadPageViewPage pageWorkers;
        private Telerik.WinControls.UI.RadGridView gridViewEmployees;
        private Telerik.WinControls.UI.RadPageViewPage pageFired;
        private Telerik.WinControls.UI.RadGridView gridViewFired;
        private Telerik.WinControls.UI.RadMenu menuMain;

    }
}
