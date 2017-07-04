using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace VacationCalc.Model
{
    class PrintEmployee : RadPrintDocument
    {
        private Employee employee;

        public PrintEmployee(Employee _employee)
        {
            employee = _employee;
        }

        protected override void PrintHeader(System.Drawing.Printing.PrintPageEventArgs args)
        {
            HeaderHeight = 170;
            Rectangle headerRect = new Rectangle(args.MarginBounds.Location, new Size(args.MarginBounds.Width, this.HeaderHeight));
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;

            Font font = new System.Drawing.Font(FontFamily.GenericSansSerif, 9.0F);
            Font HeaderFont = new System.Drawing.Font(FontFamily.GenericSerif, 15.0F);
            float X = headerRect.X;
            float Y = headerRect.Y;
            float width = headerRect.Width;
            float height = headerRect.Height;
            float marginV = 20;
            String contract = "Тип контракта: " + employee.AccountType.GetRussianName();
            String hireDate = "Начало работы: " + employee.HireDate.ToShortDateString();
            String vacationEarned = "Дней отпуска всего: " + employee.calculator.TotalVacationDays;
            String vacationSpent = "Отпуска истрачено: " + employee.calculator.VacationDaysSpent;
            String vacationLeft = "Отпуска осталось: " + employee.calculator.VacationDaysLeft;
            String vacationAtYearEnd = "Отпуска к концу года: " + employee.calculator.VacationDaysAtYearEnd;
            args.Graphics.DrawString("Информация о сотруднике", HeaderFont, Brushes.Black, new RectangleF(X, Y, width, height / 3), stringFormat);
            args.Graphics.DrawString(employee.Name, font, Brushes.Black, new PointF(X, Y + marginV));
            args.Graphics.DrawString(contract, font, Brushes.Black, new PointF(X, Y + 2 * marginV));
            args.Graphics.DrawString(hireDate, font, Brushes.Black, new PointF(X, Y + 3 * marginV));
            args.Graphics.DrawString(vacationEarned, font, Brushes.Black, new PointF(X, Y + 4 * marginV));
            args.Graphics.DrawString(vacationSpent, font, Brushes.Black, new PointF(X, Y + 5 * marginV));
            args.Graphics.DrawString(vacationLeft, font, Brushes.Black, new PointF(X, Y + 6 * marginV));
            args.Graphics.DrawString(vacationAtYearEnd, font, Brushes.Black, new PointF(X, Y + 7 * marginV));

            //Pen pen = new Pen(Brushes.Red, 3);
            //args.Graphics.DrawRectangle(pen, headerRect);

            base.PrintHeader(args);
        }

    }
}
