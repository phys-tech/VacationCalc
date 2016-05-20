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
            this.calendarDates = new Telerik.WinControls.UI.RadCalendar();
            this.lTipSelectDates = new Telerik.WinControls.UI.RadLabel();
            this.lTipDuration = new Telerik.WinControls.UI.RadLabel();
            this.bOK = new Telerik.WinControls.UI.RadButton();
            this.tbDuration = new Telerik.WinControls.UI.RadTextBox();
            this.bCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTipSelectDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTipDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarDates
            // 
            this.calendarDates.AllowMultipleSelect = true;
            this.calendarDates.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.calendarDates.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.FirstTwoLetters;
            this.calendarDates.Location = new System.Drawing.Point(38, 61);
            this.calendarDates.Name = "calendarDates";
            this.calendarDates.ShowFooter = true;
            this.calendarDates.Size = new System.Drawing.Size(260, 230);
            this.calendarDates.TabIndex = 3;
            this.calendarDates.ZoomFactor = 1F;
            this.calendarDates.SelectionChanged += new System.EventHandler(this.calendarDates_SelectionChanged);
            ((Telerik.WinControls.UI.RadCalendarElement)(this.calendarDates.GetChildAt(0))).ZoomFactor = 1F;
            ((Telerik.WinControls.UI.RadButtonElement)(this.calendarDates.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0))).Text = "Сегодня";
            ((Telerik.WinControls.UI.RadButtonElement)(this.calendarDates.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1))).Text = "Очистить";
            // 
            // lTipSelectDates
            // 
            this.lTipSelectDates.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lTipSelectDates.Location = new System.Drawing.Point(45, 25);
            this.lTipSelectDates.Name = "lTipSelectDates";
            this.lTipSelectDates.Size = new System.Drawing.Size(246, 21);
            this.lTipSelectDates.TabIndex = 4;
            this.lTipSelectDates.Text = "Укажите дату начала и конца отпуска:";
            // 
            // lTipDuration
            // 
            this.lTipDuration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lTipDuration.Location = new System.Drawing.Point(43, 311);
            this.lTipDuration.Name = "lTipDuration";
            this.lTipDuration.Size = new System.Drawing.Size(250, 21);
            this.lTipDuration.TabIndex = 5;
            this.lTipDuration.Text = "Или задайте число потраченных дней:";
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(173, 389);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(125, 37);
            this.bOK.TabIndex = 7;
            this.bOK.Text = "ОК";
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // tbDuration
            // 
            this.tbDuration.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbDuration.Location = new System.Drawing.Point(38, 338);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(260, 27);
            this.tbDuration.TabIndex = 8;
            this.tbDuration.TabStop = false;
            this.tbDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDuration.TextChanged += new System.EventHandler(this.tbDuration_TextChanged);
            this.tbDuration.Enter += new System.EventHandler(this.tbDuration_Enter);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(38, 389);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(125, 37);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Отмена";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // AddVacationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 438);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.lTipDuration);
            this.Controls.Add(this.lTipSelectDates);
            this.Controls.Add(this.calendarDates);
            this.Name = "AddVacationForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Добавление отпуска";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.calendarDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTipSelectDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTipDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCalendar calendarDates;
        private Telerik.WinControls.UI.RadLabel lTipSelectDates;
        private Telerik.WinControls.UI.RadLabel lTipDuration;
        private Telerik.WinControls.UI.RadButton bOK;
        private Telerik.WinControls.UI.RadTextBox tbDuration;
        private Telerik.WinControls.UI.RadButton bCancel;
    }
}
