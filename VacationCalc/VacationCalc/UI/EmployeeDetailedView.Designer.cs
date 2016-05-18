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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetailedView));
            this.gridViewVacations = new Telerik.WinControls.UI.RadGridView();
            this.panelTop = new Telerik.WinControls.UI.RadPanel();
            this.lEmployeeName = new Telerik.WinControls.UI.RadLabel();
            this.panelBottom = new Telerik.WinControls.UI.RadPanel();
            this.bOK = new Telerik.WinControls.UI.RadButton();
            this.comBarInfo = new Telerik.WinControls.UI.RadCommandBar();
            this.comBarRow1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.comBarStrip1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.comBarLabelHireDate = new Telerik.WinControls.UI.CommandBarLabel();
            this.comBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.comBarLabelType = new Telerik.WinControls.UI.CommandBarLabel();
            this.comBarRow2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.comBarStrip2 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.comBarLabelTotalVacation = new Telerik.WinControls.UI.CommandBarLabel();
            this.comBarLabelVacationSpent = new Telerik.WinControls.UI.CommandBarLabel();
            this.comBarLabelVacationLeft = new Telerik.WinControls.UI.CommandBarLabel();
            this.comBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.comBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lOnVacation = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVacations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVacations.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lEmployeeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBottom)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comBarInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOnVacation)).BeginInit();
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
            this.gridViewVacations.Location = new System.Drawing.Point(0, 116);
            // 
            // gridViewVacations
            // 
            this.gridViewVacations.MasterTemplate.AllowDragToGroup = false;
            this.gridViewVacations.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.AllowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "Номер";
            gridViewTextBoxColumn1.IsPinned = true;
            gridViewTextBoxColumn1.Name = "colNumber";
            gridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left;
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 92;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.FormatString = "{0:D}";
            gridViewDateTimeColumn1.HeaderText = "Начало отпуска";
            gridViewDateTimeColumn1.Name = "colStartDate";
            gridViewDateTimeColumn1.Width = 132;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.FormatString = "{0:D}";
            gridViewDateTimeColumn2.HeaderText = "Конец отпуска";
            gridViewDateTimeColumn2.Name = "colEndDate";
            gridViewDateTimeColumn2.Width = 140;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Продолжительность";
            gridViewTextBoxColumn2.Name = "colDuration";
            gridViewTextBoxColumn2.Width = 168;
            this.gridViewVacations.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn2});
            this.gridViewVacations.Name = "gridViewVacations";
            this.gridViewVacations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridViewVacations.Size = new System.Drawing.Size(577, 273);
            this.gridViewVacations.TabIndex = 2;
            this.gridViewVacations.Text = "radGridView1";
            this.gridViewVacations.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.gridViewVacations_UserDeletingRow);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lOnVacation);
            this.panelTop.Controls.Add(this.comBarInfo);
            this.panelTop.Controls.Add(this.lEmployeeName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(577, 116);
            this.panelTop.TabIndex = 3;
            // 
            // lEmployeeName
            // 
            this.lEmployeeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEmployeeName.Location = new System.Drawing.Point(76, 12);
            this.lEmployeeName.Name = "lEmployeeName";
            this.lEmployeeName.Size = new System.Drawing.Size(124, 25);
            this.lEmployeeName.TabIndex = 1;
            this.lEmployeeName.Text = "Имя работника";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.bOK);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 389);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(577, 58);
            this.panelBottom.TabIndex = 4;
            // 
            // bOK
            // 
            this.bOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.Location = new System.Drawing.Point(233, 11);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(110, 36);
            this.bOK.TabIndex = 2;
            this.bOK.Text = "ОК";
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // comBarInfo
            // 
            this.comBarInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comBarInfo.Location = new System.Drawing.Point(0, 56);
            this.comBarInfo.Name = "comBarInfo";
            this.comBarInfo.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.comBarRow1,
            this.comBarRow2});
            this.comBarInfo.Size = new System.Drawing.Size(577, 60);
            this.comBarInfo.TabIndex = 4;
            // 
            // comBarRow1
            // 
            this.comBarRow1.BorderBottomWidth = 0F;
            this.comBarRow1.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder;
            this.comBarRow1.BorderLeftWidth = 0F;
            this.comBarRow1.BorderRightWidth = 0F;
            this.comBarRow1.BorderTopWidth = 0F;
            this.comBarRow1.BorderWidth = 0F;
            this.comBarRow1.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentPadding;
            this.comBarRow1.HorizontalLineWidth = 1;
            this.comBarRow1.MinSize = new System.Drawing.Size(25, 25);
            this.comBarRow1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.comBarStrip1});
            // 
            // comBarStrip1
            // 
            this.comBarStrip1.DisplayName = "commandBarStripElement1";
            this.comBarStrip1.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds;
            // 
            // 
            // 
            this.comBarStrip1.Grip.Text = "";
            this.comBarStrip1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.comBarLabelHireDate,
            this.comBarSeparator1,
            this.comBarLabelType});
            this.comBarStrip1.Name = "commandBarStripElement1";
            // 
            // 
            // 
            this.comBarStrip1.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.comBarStrip1.ShowHorizontalLine = false;
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.comBarStrip1.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.comBarStrip1.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // comBarLabelHireDate
            // 
            this.comBarLabelHireDate.AccessibleDescription = "Принят на работу:";
            this.comBarLabelHireDate.AccessibleName = "Принят на работу:";
            this.comBarLabelHireDate.DisplayName = "commandBarLabel1";
            this.comBarLabelHireDate.Name = "comBarLabelHireDate";
            this.comBarLabelHireDate.Text = "Принят на работу:";
            this.comBarLabelHireDate.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // comBarSeparator1
            // 
            this.comBarSeparator1.AccessibleDescription = "commandBarSeparator1";
            this.comBarSeparator1.AccessibleName = "commandBarSeparator1";
            this.comBarSeparator1.DisplayName = "commandBarSeparator1";
            this.comBarSeparator1.Name = "comBarSeparator1";
            this.comBarSeparator1.Text = "";
            this.comBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.comBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // comBarLabelType
            // 
            this.comBarLabelType.AccessibleDescription = "ИП/ООО";
            this.comBarLabelType.AccessibleName = "ИП/ООО";
            this.comBarLabelType.DisplayName = "commandBarLabel2";
            this.comBarLabelType.Image = null;
            this.comBarLabelType.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.comBarLabelType.Name = "comBarLabelType";
            this.comBarLabelType.Text = "ИП/ООО";
            this.comBarLabelType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.comBarLabelType.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // comBarRow2
            // 
            this.comBarRow2.BorderBottomWidth = 0F;
            this.comBarRow2.BorderLeftWidth = 0F;
            this.comBarRow2.BorderRightWidth = 0F;
            this.comBarRow2.BorderTopWidth = 0F;
            this.comBarRow2.BorderWidth = 0F;
            this.comBarRow2.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentPadding;
            this.comBarRow2.MinSize = new System.Drawing.Size(25, 25);
            this.comBarRow2.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.comBarStrip2});
            // 
            // comBarStrip2
            // 
            this.comBarStrip2.DisplayName = "commandBarStripElement2";
            this.comBarStrip2.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds;
            this.comBarStrip2.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.comBarLabelTotalVacation,
            this.comBarSeparator2,
            this.comBarLabelVacationSpent,
            this.comBarSeparator3,
            this.comBarLabelVacationLeft});
            this.comBarStrip2.Name = "commandBarStripElement2";
            // 
            // 
            // 
            this.comBarStrip2.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.comBarStrip2.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // comBarLabelTotalVacation
            // 
            this.comBarLabelTotalVacation.AccessibleDescription = "Всего отпуска:";
            this.comBarLabelTotalVacation.AccessibleName = "Всего отпуска:";
            this.comBarLabelTotalVacation.DisplayName = "commandBarLabel3";
            this.comBarLabelTotalVacation.Name = "comBarLabelTotalVacation";
            this.comBarLabelTotalVacation.Text = "Всего отпуска:";
            this.comBarLabelTotalVacation.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // comBarLabelVacationSpent
            // 
            this.comBarLabelVacationSpent.AccessibleDescription = "Отгуляно:";
            this.comBarLabelVacationSpent.AccessibleName = "Отгуляно:";
            this.comBarLabelVacationSpent.DisplayName = "commandBarLabel4";
            this.comBarLabelVacationSpent.Name = "comBarLabelVacationSpent";
            this.comBarLabelVacationSpent.Text = "Отгуляно:";
            this.comBarLabelVacationSpent.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // comBarLabelVacationLeft
            // 
            this.comBarLabelVacationLeft.AccessibleDescription = "Осталось:";
            this.comBarLabelVacationLeft.AccessibleName = "Осталось:";
            this.comBarLabelVacationLeft.DisplayName = "commandBarLabel5";
            this.comBarLabelVacationLeft.Name = "comBarLabelVacationLeft";
            this.comBarLabelVacationLeft.Text = "Осталось:";
            this.comBarLabelVacationLeft.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.comBarLabelVacationLeft.VisibleInOverflowMenu = false;
            // 
            // comBarSeparator2
            // 
            this.comBarSeparator2.AccessibleDescription = "commandBarSeparator2";
            this.comBarSeparator2.AccessibleName = "commandBarSeparator2";
            this.comBarSeparator2.DisplayName = "commandBarSeparator2";
            this.comBarSeparator2.Name = "comBarSeparator2";
            this.comBarSeparator2.Text = "";
            this.comBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.comBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // comBarSeparator3
            // 
            this.comBarSeparator3.AccessibleDescription = "commandBarSeparator3";
            this.comBarSeparator3.AccessibleName = "commandBarSeparator3";
            this.comBarSeparator3.DisplayName = "commandBarSeparator3";
            this.comBarSeparator3.Name = "comBarSeparator3";
            this.comBarSeparator3.Text = "";
            this.comBarSeparator3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.comBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "OnVacation.png");
            // 
            // lOnVacation
            // 
            this.lOnVacation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lOnVacation.Image = ((System.Drawing.Image)(resources.GetObject("lOnVacation.Image")));
            this.lOnVacation.ImageIndex = 0;
            this.lOnVacation.ImageList = this.imageList;
            this.lOnVacation.Location = new System.Drawing.Point(451, 3);
            this.lOnVacation.Name = "lOnVacation";
            this.lOnVacation.Size = new System.Drawing.Size(123, 66);
            this.lOnVacation.SmallImageList = this.imageList;
            this.lOnVacation.TabIndex = 5;
            this.lOnVacation.Text = "В отпуске!";
            this.lOnVacation.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lOnVacation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // EmployeeDetailedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 447);
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
            ((System.ComponentModel.ISupportInitialize)(this.lEmployeeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBottom)).EndInit();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comBarInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOnVacation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridViewVacations;
        private Telerik.WinControls.UI.RadPanel panelTop;
        private Telerik.WinControls.UI.RadLabel lEmployeeName;
        private Telerik.WinControls.UI.RadPanel panelBottom;
        private Telerik.WinControls.UI.RadButton bOK;
        private Telerik.WinControls.UI.RadCommandBar comBarInfo;
        private Telerik.WinControls.UI.CommandBarRowElement comBarRow1;
        private Telerik.WinControls.UI.CommandBarStripElement comBarStrip1;
        private Telerik.WinControls.UI.CommandBarLabel comBarLabelHireDate;
        private Telerik.WinControls.UI.CommandBarSeparator comBarSeparator1;
        private Telerik.WinControls.UI.CommandBarLabel comBarLabelType;
        private Telerik.WinControls.UI.CommandBarRowElement comBarRow2;
        private Telerik.WinControls.UI.CommandBarStripElement comBarStrip2;
        private Telerik.WinControls.UI.CommandBarLabel comBarLabelTotalVacation;
        private Telerik.WinControls.UI.CommandBarLabel comBarLabelVacationSpent;
        private Telerik.WinControls.UI.CommandBarLabel comBarLabelVacationLeft;
        private Telerik.WinControls.UI.CommandBarSeparator comBarSeparator2;
        private Telerik.WinControls.UI.CommandBarSeparator comBarSeparator3;
        private System.Windows.Forms.ImageList imageList;
        private Telerik.WinControls.UI.RadLabel lOnVacation;
    }
}
