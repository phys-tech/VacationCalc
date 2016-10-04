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
            this.calendarHolidays = new Telerik.WinControls.UI.RadCalendar();
            this.bOK = new Telerik.WinControls.UI.RadButton();
            this.labelSelectedDates = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.calendarHolidays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSelectedDates)).BeginInit();
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
            this.calendarHolidays.Location = new System.Drawing.Point(21, 25);
            this.calendarHolidays.Name = "calendarHolidays";
            this.calendarHolidays.RangeMaxDate = new System.DateTime(2050, 12, 30, 0, 0, 0, 0);
            this.calendarHolidays.RangeMinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.calendarHolidays.Size = new System.Drawing.Size(323, 283);
            this.calendarHolidays.TabIndex = 0;
            this.calendarHolidays.Text = "Holidays Calendar";
            this.calendarHolidays.ZoomFactor = 1F;
            this.calendarHolidays.SelectionChanged += new System.EventHandler(this.calendarHolidays_SelectionChanged);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(227, 350);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(150, 43);
            this.bOK.TabIndex = 1;
            this.bOK.Text = "OK";
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // labelSelectedDates
            // 
            this.labelSelectedDates.Location = new System.Drawing.Point(373, 25);
            this.labelSelectedDates.Name = "labelSelectedDates";
            this.labelSelectedDates.Size = new System.Drawing.Size(105, 18);
            this.labelSelectedDates.TabIndex = 3;
            this.labelSelectedDates.Text = "Selected dates label";
            // 
            // HolidaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 428);
            this.Controls.Add(this.labelSelectedDates);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.calendarHolidays);
            this.Name = "HolidaysForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Календарь выходных";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.calendarHolidays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSelectedDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCalendar calendarHolidays;
        private Telerik.WinControls.UI.RadButton bOK;
        private Telerik.WinControls.UI.RadLabel labelSelectedDates;
    }
}
