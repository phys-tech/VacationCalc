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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.gridViewEmployees = new Telerik.WinControls.UI.RadGridView();
            this.menuMain = new Telerik.WinControls.UI.RadMenu();
            this.menuItemTop = new Telerik.WinControls.UI.RadMenuItem();
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.panelTools = new Telerik.WinControls.UI.RadPanel();
            this.bSave = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
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
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "ФИО";
            gridViewTextBoxColumn3.Name = "colName";
            gridViewTextBoxColumn3.Width = 168;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.HeaderText = "Дата приема";
            gridViewDateTimeColumn2.Name = "colHireDate";
            gridViewDateTimeColumn2.Width = 99;
            gridViewComboBoxColumn2.EnableExpressionEditor = false;
            gridViewComboBoxColumn2.HeaderText = "Тип занятости";
            gridViewComboBoxColumn2.Name = "colAccType";
            gridViewComboBoxColumn2.Width = 106;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "Кол-во оставшихся дней отпуска";
            gridViewTextBoxColumn4.Name = "colVacationLeft";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 234;
            this.gridViewEmployees.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewDateTimeColumn2,
            gridViewComboBoxColumn2,
            gridViewTextBoxColumn4});
            this.gridViewEmployees.Name = "gridViewEmployees";
            this.gridViewEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridViewEmployees.Size = new System.Drawing.Size(799, 470);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 542);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(799, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "radStatusStrip1";
            // 
            // panelTools
            // 
            this.panelTools.Controls.Add(this.radButton2);
            this.panelTools.Controls.Add(this.bSave);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTools.Location = new System.Drawing.Point(0, 490);
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

    }
}
