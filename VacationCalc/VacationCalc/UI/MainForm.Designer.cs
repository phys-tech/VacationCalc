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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn4 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn7 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn8 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor4 = new Telerik.WinControls.Data.SortDescriptor();
            this.gridViewEmployees = new Telerik.WinControls.UI.RadGridView();
            this.menuMain = new Telerik.WinControls.UI.RadMenu();
            this.menuItemTop = new Telerik.WinControls.UI.RadMenuItem();
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.statusLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.statusLabel2 = new Telerik.WinControls.UI.RadLabelElement();
            this.panelTools = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewEmployees
            // 
            this.gridViewEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gridViewEmployees.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridViewEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewEmployees.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridViewEmployees.ForeColor = System.Drawing.Color.Black;
            this.gridViewEmployees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridViewEmployees.Location = new System.Drawing.Point(0, 20);
            // 
            // gridViewEmployees
            // 
            this.gridViewEmployees.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridViewEmployees.MasterTemplate.AutoGenerateColumns = false;
            this.gridViewEmployees.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.HeaderText = "ID";
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "colID";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.HeaderText = "ФИО";
            gridViewTextBoxColumn11.Name = "colName";
            gridViewTextBoxColumn11.Width = 230;
            gridViewDateTimeColumn4.EnableExpressionEditor = false;
            gridViewDateTimeColumn4.FilteringMode = Telerik.WinControls.UI.GridViewTimeFilteringMode.Date;
            gridViewDateTimeColumn4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn4.FormatString = "{0:D}";
            gridViewDateTimeColumn4.HeaderText = "Дата приема";
            gridViewDateTimeColumn4.Name = "colHireDate";
            gridViewDateTimeColumn4.Width = 125;
            gridViewComboBoxColumn4.EnableExpressionEditor = false;
            gridViewComboBoxColumn4.HeaderText = "Тип занятости";
            gridViewComboBoxColumn4.Name = "colAccType";
            gridViewComboBoxColumn4.Width = 98;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.HeaderText = "Кол-во оставшихся дней отпуска";
            gridViewTextBoxColumn12.Name = "colVacationLeft";
            gridViewTextBoxColumn12.ReadOnly = true;
            gridViewTextBoxColumn12.Width = 195;
            gridViewCommandColumn7.DefaultText = "Добавить...";
            gridViewCommandColumn7.EnableExpressionEditor = false;
            gridViewCommandColumn7.HeaderText = "Отпуск";
            gridViewCommandColumn7.Name = "colAddVacation";
            gridViewCommandColumn7.UseDefaultText = true;
            gridViewCommandColumn7.Width = 74;
            gridViewCommandColumn8.DefaultText = "Просмотр";
            gridViewCommandColumn8.EnableExpressionEditor = false;
            gridViewCommandColumn8.HeaderText = "Инфо";
            gridViewCommandColumn8.Name = "colView";
            gridViewCommandColumn8.UseDefaultText = true;
            gridViewCommandColumn8.Width = 61;
            this.gridViewEmployees.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewDateTimeColumn4,
            gridViewComboBoxColumn4,
            gridViewTextBoxColumn12,
            gridViewCommandColumn7,
            gridViewCommandColumn8});
            sortDescriptor4.PropertyName = "colButton";
            this.gridViewEmployees.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor4});
            this.gridViewEmployees.Name = "gridViewEmployees";
            this.gridViewEmployees.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell;
            this.gridViewEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridViewEmployees.Size = new System.Drawing.Size(799, 470);
            this.gridViewEmployees.TabIndex = 0;
            this.gridViewEmployees.UserAddingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.gridViewEmployees_UserAddingRow);
            this.gridViewEmployees.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.gridViewEmployees_UserDeletingRow);
            this.gridViewEmployees.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridViewEmployees_CellValueChanged);
            this.gridViewEmployees.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
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
            // 
            // menuItemTop
            // 
            this.menuItemTop.AccessibleDescription = "Меню";
            this.menuItemTop.AccessibleName = "Меню";
            this.menuItemTop.Name = "menuItemTop";
            this.menuItemTop.Text = "Меню";
            this.menuItemTop.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.statusLabel,
            this.statusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 542);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(799, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "radStatusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.AccessibleDescription = "statusLabel";
            this.statusLabel.AccessibleName = "statusLabel";
            this.statusLabel.Name = "statusLabel";
            this.statusStrip.SetSpring(this.statusLabel, false);
            this.statusLabel.Text = "NumberOfEmpl";
            this.statusLabel.TextWrap = true;
            this.statusLabel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // statusLabel2
            // 
            this.statusLabel2.AccessibleDescription = "statusLabel2";
            this.statusLabel2.AccessibleName = "statusLabel2";
            this.statusLabel2.Name = "statusLabel2";
            this.statusStrip.SetSpring(this.statusLabel2, false);
            this.statusLabel2.Text = "NumberOfOnVacation";
            this.statusLabel2.TextWrap = true;
            this.statusLabel2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // panelTools
            // 
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTools.Location = new System.Drawing.Point(0, 490);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(799, 52);
            this.panelTools.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 566);
            this.Controls.Add(this.gridViewEmployees);
            this.Controls.Add(this.panelTools);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridViewEmployees;
        private Telerik.WinControls.UI.RadMenu menuMain;
        private Telerik.WinControls.UI.RadMenuItem menuItemTop;
        private Telerik.WinControls.UI.RadStatusStrip statusStrip;
        private Telerik.WinControls.UI.RadPanel panelTools;
        private Telerik.WinControls.UI.RadLabelElement statusLabel;
        private Telerik.WinControls.UI.RadLabelElement statusLabel2;

    }
}
