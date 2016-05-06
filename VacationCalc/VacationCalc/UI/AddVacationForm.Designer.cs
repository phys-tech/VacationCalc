namespace VacationCalc
{
    partial class AddVacationForm
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
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.calStartDate = new Telerik.WinControls.UI.RadCalendar();
            this.calEndDate = new Telerik.WinControls.UI.RadCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.Location = new System.Drawing.Point(462, 12);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.radDateTimePicker1.TabIndex = 2;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "Friday, May 06, 2016";
            this.radDateTimePicker1.Value = new System.DateTime(2016, 5, 6, 12, 40, 31, 54);
            // 
            // calStartDate
            // 
            this.calStartDate.AllowMultipleSelect = true;
            this.calStartDate.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.calStartDate.Location = new System.Drawing.Point(38, 59);
            this.calStartDate.Name = "calStartDate";
            this.calStartDate.ShowFooter = true;
            this.calStartDate.Size = new System.Drawing.Size(257, 227);
            this.calStartDate.TabIndex = 3;
            this.calStartDate.Text = "radCalendar1";
            ((Telerik.WinControls.UI.RadButtonElement)(this.calStartDate.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0))).Text = "Сегодня";
            ((Telerik.WinControls.UI.RadButtonElement)(this.calStartDate.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1))).Text = "Очистить";
            // 
            // calEndDate
            // 
            this.calEndDate.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.calEndDate.Location = new System.Drawing.Point(320, 59);
            this.calEndDate.Name = "calEndDate";
            this.calEndDate.ShowFooter = true;
            this.calEndDate.Size = new System.Drawing.Size(257, 227);
            this.calEndDate.TabIndex = 4;
            this.calEndDate.Text = "radCalendar1";
            ((Telerik.WinControls.UI.RadButtonElement)(this.calEndDate.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0))).Text = "Сегодня";
            ((Telerik.WinControls.UI.RadButtonElement)(this.calEndDate.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1))).Text = "Очистить";
            // 
            // AddVacationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 518);
            this.Controls.Add(this.calEndDate);
            this.Controls.Add(this.calStartDate);
            this.Controls.Add(this.radDateTimePicker1);
            this.Name = "AddVacationForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Добавление отпуска";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadCalendar calStartDate;
        private Telerik.WinControls.UI.RadCalendar calEndDate;
    }
}
