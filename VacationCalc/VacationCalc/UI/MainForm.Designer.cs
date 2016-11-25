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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn25 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn13 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn9 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn14 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject9 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.GridViewMaskBoxColumn gridViewMaskBoxColumn5 = new Telerik.WinControls.UI.GridViewMaskBoxColumn();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject10 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn17 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn18 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor9 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn28 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn29 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn15 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn10 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn30 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn19 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn20 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor10 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark5 = new Telerik.WinControls.UI.RadPrintWatermark();
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
            this.menuPrintMobiles = new Telerik.WinControls.UI.RadMenuItem();
            this.printDocumentRad = new Telerik.WinControls.UI.RadPrintDocument();
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
            gridViewTextBoxColumn25.EnableExpressionEditor = false;
            gridViewTextBoxColumn25.HeaderText = "ID";
            gridViewTextBoxColumn25.IsVisible = false;
            gridViewTextBoxColumn25.Name = "colID";
            gridViewTextBoxColumn25.ReadOnly = true;
            gridViewTextBoxColumn26.EnableExpressionEditor = false;
            gridViewTextBoxColumn26.HeaderText = "ФИО";
            gridViewTextBoxColumn26.Name = "colName";
            gridViewTextBoxColumn26.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn26.Width = 184;
            gridViewDateTimeColumn13.EnableExpressionEditor = false;
            gridViewDateTimeColumn13.FilteringMode = Telerik.WinControls.UI.GridViewTimeFilteringMode.Date;
            gridViewDateTimeColumn13.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn13.FormatString = "{0:D}";
            gridViewDateTimeColumn13.HeaderText = "Дата приема";
            gridViewDateTimeColumn13.Name = "colHireDate";
            gridViewDateTimeColumn13.Width = 87;
            gridViewComboBoxColumn9.EnableExpressionEditor = false;
            gridViewComboBoxColumn9.HeaderText = "Тип занятости";
            gridViewComboBoxColumn9.Name = "colAccType";
            gridViewComboBoxColumn9.Width = 104;
            gridViewTextBoxColumn27.EnableExpressionEditor = false;
            gridViewTextBoxColumn27.HeaderText = "Кол-во оставшихся дней отпуска";
            gridViewTextBoxColumn27.Name = "colVacationLeft";
            gridViewTextBoxColumn27.ReadOnly = true;
            gridViewTextBoxColumn27.Width = 196;
            conditionalFormattingObject9.CellBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject9.CellForeColor = System.Drawing.Color.Red;
            conditionalFormattingObject9.ConditionType = Telerik.WinControls.UI.ConditionTypes.GreaterOrEqual;
            conditionalFormattingObject9.Name = "BirthdayNotSet";
            conditionalFormattingObject9.RowBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject9.RowForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject9.TValue1 = "1.01.2000";
            gridViewDateTimeColumn14.ConditionalFormattingObjectList.Add(conditionalFormattingObject9);
            gridViewDateTimeColumn14.EnableExpressionEditor = false;
            gridViewDateTimeColumn14.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn14.FormatString = "{0:dd.MM.yyyy}";
            gridViewDateTimeColumn14.HeaderText = "День рождения";
            gridViewDateTimeColumn14.Name = "colBirthDate";
            gridViewDateTimeColumn14.Width = 99;
            conditionalFormattingObject10.CellBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject10.CellForeColor = System.Drawing.Color.Red;
            conditionalFormattingObject10.Name = "MobileNotSet";
            conditionalFormattingObject10.RowBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject10.RowForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject10.TValue1 = "0000";
            gridViewMaskBoxColumn5.ConditionalFormattingObjectList.Add(conditionalFormattingObject10);
            gridViewMaskBoxColumn5.EnableExpressionEditor = false;
            gridViewMaskBoxColumn5.FieldName = "Мобильный";
            gridViewMaskBoxColumn5.HeaderText = "Мобильный";
            gridViewMaskBoxColumn5.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            gridViewMaskBoxColumn5.Name = "colMobile";
            gridViewMaskBoxColumn5.Width = 93;
            gridViewCommandColumn17.DefaultText = "Добавить...";
            gridViewCommandColumn17.EnableExpressionEditor = false;
            gridViewCommandColumn17.HeaderText = "Отпуск";
            gridViewCommandColumn17.Name = "colAddVacation";
            gridViewCommandColumn17.UseDefaultText = true;
            gridViewCommandColumn17.Width = 63;
            gridViewCommandColumn18.DefaultText = "Просмотр";
            gridViewCommandColumn18.EnableExpressionEditor = false;
            gridViewCommandColumn18.HeaderText = "Инфо";
            gridViewCommandColumn18.Name = "colView";
            gridViewCommandColumn18.UseDefaultText = true;
            gridViewCommandColumn18.Width = 90;
            this.gridViewEmployees.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn25,
            gridViewTextBoxColumn26,
            gridViewDateTimeColumn13,
            gridViewComboBoxColumn9,
            gridViewTextBoxColumn27,
            gridViewDateTimeColumn14,
            gridViewMaskBoxColumn5,
            gridViewCommandColumn17,
            gridViewCommandColumn18});
            sortDescriptor9.PropertyName = "colName";
            this.gridViewEmployees.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor9});
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
            gridViewTextBoxColumn28.EnableExpressionEditor = false;
            gridViewTextBoxColumn28.HeaderText = "ID";
            gridViewTextBoxColumn28.IsVisible = false;
            gridViewTextBoxColumn28.Name = "colID";
            gridViewTextBoxColumn28.ReadOnly = true;
            gridViewTextBoxColumn29.EnableExpressionEditor = false;
            gridViewTextBoxColumn29.HeaderText = "ФИО";
            gridViewTextBoxColumn29.Name = "colName";
            gridViewTextBoxColumn29.Width = 268;
            gridViewDateTimeColumn15.EnableExpressionEditor = false;
            gridViewDateTimeColumn15.FilteringMode = Telerik.WinControls.UI.GridViewTimeFilteringMode.Date;
            gridViewDateTimeColumn15.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn15.FormatString = "{0:D}";
            gridViewDateTimeColumn15.HeaderText = "Дата приема";
            gridViewDateTimeColumn15.Name = "colHireDate";
            gridViewDateTimeColumn15.Width = 146;
            gridViewComboBoxColumn10.EnableExpressionEditor = false;
            gridViewComboBoxColumn10.HeaderText = "Тип занятости";
            gridViewComboBoxColumn10.Name = "colAccType";
            gridViewComboBoxColumn10.Width = 115;
            gridViewTextBoxColumn30.EnableExpressionEditor = false;
            gridViewTextBoxColumn30.HeaderText = "Кол-во оставшихся дней отпуска";
            gridViewTextBoxColumn30.Name = "colVacationLeft";
            gridViewTextBoxColumn30.ReadOnly = true;
            gridViewTextBoxColumn30.Width = 227;
            gridViewCommandColumn19.DefaultText = "Добавить...";
            gridViewCommandColumn19.EnableExpressionEditor = false;
            gridViewCommandColumn19.HeaderText = "Отпуск";
            gridViewCommandColumn19.Name = "colAddVacation";
            gridViewCommandColumn19.UseDefaultText = true;
            gridViewCommandColumn19.Width = 87;
            gridViewCommandColumn20.DefaultText = "Просмотр";
            gridViewCommandColumn20.EnableExpressionEditor = false;
            gridViewCommandColumn20.HeaderText = "Инфо";
            gridViewCommandColumn20.Name = "colView";
            gridViewCommandColumn20.UseDefaultText = true;
            gridViewCommandColumn20.Width = 71;
            this.gridViewFired.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn28,
            gridViewTextBoxColumn29,
            gridViewDateTimeColumn15,
            gridViewComboBoxColumn10,
            gridViewTextBoxColumn30,
            gridViewCommandColumn19,
            gridViewCommandColumn20});
            sortDescriptor10.PropertyName = "colButton";
            this.gridViewFired.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor10});
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
            this.menuHolidaysCalendar,
            this.menuPrintMobiles});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(951, 20);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "radMenu1";
            // 
            // menuPrintMobiles
            // 
            this.menuPrintMobiles.AccessibleDescription = "Печать телефонов";
            this.menuPrintMobiles.AccessibleName = "Печать телефонов";
            this.menuPrintMobiles.Name = "menuPrintMobiles";
            this.menuPrintMobiles.Text = "Печать телефонов";
            this.menuPrintMobiles.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.menuPrintMobiles.Click += new System.EventHandler(this.menuPrintMobiles_Click);
            // 
            // printDocumentRad
            // 
            this.printDocumentRad.AssociatedObject = this.gridViewEmployees;
            this.printDocumentRad.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printDocumentRad.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printDocumentRad.LeftFooter = "Left1";
            this.printDocumentRad.LeftHeader = "Left2";
            this.printDocumentRad.MiddleFooter = "Mid1";
            this.printDocumentRad.MiddleHeader = "Mid2";
            this.printDocumentRad.RightFooter = "Rightr1";
            this.printDocumentRad.RightHeader = "Right2";
            this.printDocumentRad.Watermark = radPrintWatermark5;
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
        private Telerik.WinControls.UI.RadMenuItem menuPrintMobiles;
        private Telerik.WinControls.UI.RadPrintDocument printDocumentRad;

    }
}
