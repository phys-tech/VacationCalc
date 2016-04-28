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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.gridViewEmployees = new Telerik.WinControls.UI.RadGridView();
            this.menuMain = new Telerik.WinControls.UI.RadMenu();
            this.menuItemTop = new Telerik.WinControls.UI.RadMenuItem();
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.panelTools = new Telerik.WinControls.UI.RadPanel();
            this.bSave = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radProgressBarElement1 = new Telerik.WinControls.UI.RadProgressBarElement();
            this.radCheckBoxElement1 = new Telerik.WinControls.UI.RadCheckBoxElement();
            this.radToggleButtonElement1 = new Telerik.WinControls.UI.RadToggleButtonElement();
            this.radWaitingBarElement1 = new Telerik.WinControls.UI.RadWaitingBarElement();
            this.radSplitButtonElement1 = new Telerik.WinControls.UI.RadSplitButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTools)).BeginInit();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
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
            this.gridViewEmployees.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "ФИО";
            gridViewTextBoxColumn1.Name = "colName";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn1.Width = 221;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.HeaderText = "Дата приема";
            gridViewDateTimeColumn1.Name = "colHireDate";
            gridViewDateTimeColumn1.Width = 132;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.HeaderText = "Тип занятости";
            gridViewComboBoxColumn1.Name = "colAccType";
            gridViewComboBoxColumn1.Width = 106;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Кол-во оставшихся дней отпуска";
            gridViewTextBoxColumn2.Name = "colVacationLeft";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 234;
            this.gridViewEmployees.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn2});
            sortDescriptor1.PropertyName = "colName";
            this.gridViewEmployees.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gridViewEmployees.Name = "gridViewEmployees";
            this.gridViewEmployees.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell;
            this.gridViewEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridViewEmployees.Size = new System.Drawing.Size(799, 468);
            this.gridViewEmployees.TabIndex = 0;
            this.gridViewEmployees.UserAddedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.gridViewEmployees_UserAddedRow);
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
            this.radButtonElement1,
            this.radProgressBarElement1,
            this.radCheckBoxElement1,
            this.radToggleButtonElement1,
            this.radWaitingBarElement1,
            this.radSplitButtonElement1});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(799, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "radStatusStrip1";
            // 
            // panelTools
            // 
            this.panelTools.Controls.Add(this.radButton2);
            this.panelTools.Controls.Add(this.bSave);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTools.Location = new System.Drawing.Point(0, 488);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(799, 52);
            this.panelTools.TabIndex = 3;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(402, 6);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(128, 40);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Сохранить";
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(235, 6);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(128, 40);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "radButton2";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "radButtonElement1";
            this.radButtonElement1.AccessibleName = "radButtonElement1";
            this.radButtonElement1.Name = "radButtonElement1";
            this.statusStrip.SetSpring(this.radButtonElement1, false);
            this.radButtonElement1.Text = "radButtonElement1";
            this.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radProgressBarElement1
            // 
            this.radProgressBarElement1.Name = "radProgressBarElement1";
            this.radProgressBarElement1.SeparatorColor1 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorColor2 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorColor3 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorColor4 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorGradientAngle = 0;
            this.radProgressBarElement1.SeparatorGradientPercentage1 = 0.4F;
            this.radProgressBarElement1.SeparatorGradientPercentage2 = 0.6F;
            this.radProgressBarElement1.SeparatorNumberOfColors = 2;
            this.statusStrip.SetSpring(this.radProgressBarElement1, false);
            this.radProgressBarElement1.StepWidth = 14;
            this.radProgressBarElement1.SweepAngle = 90;
            this.radProgressBarElement1.Text = "";
            this.radProgressBarElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radCheckBoxElement1
            // 
            this.radCheckBoxElement1.AccessibleDescription = "radCheckBoxElement1";
            this.radCheckBoxElement1.AccessibleName = "radCheckBoxElement1";
            this.radCheckBoxElement1.Checked = false;
            this.radCheckBoxElement1.Name = "radCheckBoxElement1";
            this.statusStrip.SetSpring(this.radCheckBoxElement1, false);
            this.radCheckBoxElement1.Text = "radCheckBoxElement1";
            this.radCheckBoxElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radToggleButtonElement1
            // 
            this.radToggleButtonElement1.AccessibleDescription = "radToggleButtonElement1";
            this.radToggleButtonElement1.AccessibleName = "radToggleButtonElement1";
            this.radToggleButtonElement1.Name = "radToggleButtonElement1";
            this.statusStrip.SetSpring(this.radToggleButtonElement1, false);
            this.radToggleButtonElement1.Text = "radToggleButtonElement1";
            this.radToggleButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radWaitingBarElement1
            // 
            this.radWaitingBarElement1.AccessibleDescription = "radWaitingBarElement1";
            this.radWaitingBarElement1.AccessibleName = "radWaitingBarElement1";
            this.radWaitingBarElement1.Name = "radWaitingBarElement1";
            this.statusStrip.SetSpring(this.radWaitingBarElement1, false);
            this.radWaitingBarElement1.Text = "radWaitingBarElement1";
            this.radWaitingBarElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radSplitButtonElement1
            // 
            this.radSplitButtonElement1.AccessibleDescription = "radSplitButtonElement1";
            this.radSplitButtonElement1.AccessibleName = "radSplitButtonElement1";
            this.radSplitButtonElement1.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            this.radSplitButtonElement1.DefaultItem = null;
            this.radSplitButtonElement1.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down;
            this.radSplitButtonElement1.ExpandArrowButton = false;
            this.radSplitButtonElement1.Name = "radSplitButtonElement1";
            this.statusStrip.SetSpring(this.radSplitButtonElement1, false);
            this.radSplitButtonElement1.Text = "radSplitButtonElement1";
            this.radSplitButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTools)).EndInit();
            this.panelTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
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
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton bSave;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadProgressBarElement radProgressBarElement1;
        private Telerik.WinControls.UI.RadCheckBoxElement radCheckBoxElement1;
        private Telerik.WinControls.UI.RadToggleButtonElement radToggleButtonElement1;
        private Telerik.WinControls.UI.RadWaitingBarElement radWaitingBarElement1;
        private Telerik.WinControls.UI.RadSplitButtonElement radSplitButtonElement1;

    }
}
