namespace VacationCalc.UI
{
    partial class HolidaysForm
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Column 0");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Column 1");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Column 2");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Column 3");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HolidaysForm));
            this.calendarHolidays = new Telerik.WinControls.UI.RadCalendar();
            this.bOK = new Telerik.WinControls.UI.RadButton();
            this.listViewSelectedDates = new Telerik.WinControls.UI.RadListView();
            ((System.ComponentModel.ISupportInitialize)(this.calendarHolidays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewSelectedDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarHolidays
            // 
            this.calendarHolidays.AllowMultipleSelect = true;
            this.calendarHolidays.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.calendarHolidays.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.FirstTwoLetters;
            this.calendarHolidays.FirstDayOfWeek = Telerik.WinControls.UI.FirstDayOfWeek.Monday;
            this.calendarHolidays.FocusedDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.calendarHolidays.Location = new System.Drawing.Point(23, 27);
            this.calendarHolidays.Name = "calendarHolidays";
            this.calendarHolidays.RangeMaxDate = new System.DateTime(2050, 12, 30, 0, 0, 0, 0);
            this.calendarHolidays.RangeMinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.calendarHolidays.Size = new System.Drawing.Size(250, 250);
            this.calendarHolidays.TabIndex = 0;
            this.calendarHolidays.Text = "Holidays Calendar";
            this.calendarHolidays.ZoomFactor = 1F;
            this.calendarHolidays.SelectionChanged += new System.EventHandler(this.calendarHolidays_SelectionChanged);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(221, 302);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(150, 43);
            this.bOK.TabIndex = 1;
            this.bOK.Text = "OK";
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // listViewSelectedDates
            // 
            listViewDetailColumn1.HeaderText = "Column 0";
            listViewDetailColumn2.HeaderText = "Column 1";
            listViewDetailColumn3.HeaderText = "Column 2";
            listViewDetailColumn4.HeaderText = "Column 3";
            this.listViewSelectedDates.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.listViewSelectedDates.Location = new System.Drawing.Point(320, 27);
            this.listViewSelectedDates.Name = "listViewSelectedDates";
            this.listViewSelectedDates.SelectLastAddedItem = false;
            this.listViewSelectedDates.Size = new System.Drawing.Size(250, 250);
            this.listViewSelectedDates.TabIndex = 4;
            // 
            // HolidaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 380);
            this.Controls.Add(this.listViewSelectedDates);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.calendarHolidays);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HolidaysForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Календарь выходных";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.calendarHolidays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewSelectedDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCalendar calendarHolidays;
        private Telerik.WinControls.UI.RadButton bOK;
        private Telerik.WinControls.UI.RadListView listViewSelectedDates;
    }
}
