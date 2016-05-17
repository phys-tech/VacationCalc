namespace VacationCalc
{
    partial class EmployeeDetailedView
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.gridViewVacations = new Telerik.WinControls.UI.RadGridView();
            this.panelTop = new Telerik.WinControls.UI.RadPanel();
            this.lAccountType = new Telerik.WinControls.UI.RadLabel();
            this.lHireDate = new Telerik.WinControls.UI.RadLabel();
            this.lEmployeeName = new Telerik.WinControls.UI.RadLabel();
            this.panelBottom = new Telerik.WinControls.UI.RadPanel();
            this.bOK = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVacations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVacations.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lHireDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEmployeeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBottom)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewVacations
            // 
            this.gridViewVacations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gridViewVacations.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridViewVacations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewVacations.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridViewVacations.ForeColor = System.Drawing.Color.Black;
            this.gridViewVacations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridViewVacations.Location = new System.Drawing.Point(0, 64);
            // 
            // gridViewVacations
            // 
            this.gridViewVacations.MasterTemplate.AllowDragToGroup = false;
            this.gridViewVacations.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "Номер";
            gridViewTextBoxColumn1.Name = "colNumber";
            gridViewTextBoxColumn1.Width = 81;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.FormatString = "{0:D}";
            gridViewDateTimeColumn1.HeaderText = "Начало отпуска";
            gridViewDateTimeColumn1.Name = "colStartDate";
            gridViewDateTimeColumn1.Width = 136;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.FormatString = "{0:D}";
            gridViewDateTimeColumn2.HeaderText = "Конец отпуска";
            gridViewDateTimeColumn2.Name = "colEndDate";
            gridViewDateTimeColumn2.Width = 144;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Продолжительность";
            gridViewTextBoxColumn2.Name = "colDuration";
            gridViewTextBoxColumn2.Width = 171;
            this.gridViewVacations.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn2});
            this.gridViewVacations.Name = "gridViewVacations";
            this.gridViewVacations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridViewVacations.Size = new System.Drawing.Size(550, 272);
            this.gridViewVacations.TabIndex = 2;
            this.gridViewVacations.Text = "radGridView1";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lAccountType);
            this.panelTop.Controls.Add(this.lHireDate);
            this.panelTop.Controls.Add(this.lEmployeeName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(550, 64);
            this.panelTop.TabIndex = 3;
            // 
            // lAccountType
            // 
            this.lAccountType.Location = new System.Drawing.Point(271, 12);
            this.lAccountType.Name = "lAccountType";
            this.lAccountType.Size = new System.Drawing.Size(28, 18);
            this.lAccountType.TabIndex = 3;
            this.lAccountType.Text = "Тип ";
            // 
            // lHireDate
            // 
            this.lHireDate.Location = new System.Drawing.Point(12, 40);
            this.lHireDate.Name = "lHireDate";
            this.lHireDate.Size = new System.Drawing.Size(73, 18);
            this.lHireDate.TabIndex = 2;
            this.lHireDate.Text = "Дата приема";
            // 
            // lEmployeeName
            // 
            this.lEmployeeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEmployeeName.Location = new System.Drawing.Point(12, 12);
            this.lEmployeeName.Name = "lEmployeeName";
            this.lEmployeeName.Size = new System.Drawing.Size(124, 25);
            this.lEmployeeName.TabIndex = 1;
            this.lEmployeeName.Text = "Имя работника";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.bOK);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 336);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(550, 58);
            this.panelBottom.TabIndex = 4;
            // 
            // bOK
            // 
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.Location = new System.Drawing.Point(428, 10);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(110, 36);
            this.bOK.TabIndex = 2;
            this.bOK.Text = "ОК";
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // EmployeeDetailedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 394);
            this.Controls.Add(this.gridViewVacations);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "EmployeeDetailedView";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Просмотр информации о сотруднике";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.EmployeeDetailedView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVacations.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVacations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lAccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lHireDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEmployeeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBottom)).EndInit();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridViewVacations;
        private Telerik.WinControls.UI.RadPanel panelTop;
        private Telerik.WinControls.UI.RadLabel lEmployeeName;
        private Telerik.WinControls.UI.RadPanel panelBottom;
        private Telerik.WinControls.UI.RadButton bOK;
        private Telerik.WinControls.UI.RadLabel lAccountType;
        private Telerik.WinControls.UI.RadLabel lHireDate;
    }
}
