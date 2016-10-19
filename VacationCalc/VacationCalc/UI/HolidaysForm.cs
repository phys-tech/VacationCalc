using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Xml.Linq;
using System.IO;

namespace VacationCalc.UI
{
    public partial class HolidaysForm : Telerik.WinControls.UI.RadForm
    {
        private IEnumerable<DateTime> sortedDates;
        private string XmlFilename = "Holidays.xml";

        public HolidaysForm()
        {
            InitializeComponent();
            LoadDatesFromXML();
            UpdateDatesOnLabel();
        }

        private void UpdateDatesOnLabel()
        {
            listViewSelectedDates.Items.Clear();
            foreach (DateTime date in sortedDates)
                listViewSelectedDates.Items.Add(date.ToLongDateString());
        }

        private void calendarHolidays_SelectionChanged(object sender, EventArgs e)
        {            
            sortedDates = calendarHolidays.SelectedDates;
            sortedDates = sortedDates.OrderBy(u => u.Date);
            UpdateDatesOnLabel();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            SaveDatesToXML();
            this.Close();
        }

        private void SaveDatesToXML()
        {
            XDocument doc = new XDocument(new XElement("Root"));
            foreach (DateTime date in sortedDates)
            {
                XElement element = new XElement("Holiday",
                                    new XElement("Date", date.Date));
                doc.Root.Add(element);
            }
            doc.Save(XmlFilename);
        }

        private void LoadDatesFromXML()
        {
            XDocument doc = XDocument.Load(XmlFilename);            
            List<DateTime> tempList = new List<DateTime>();
            foreach (XElement element in doc.Root.Elements())
            { 
                DateTime date = DateTime.Parse(element.Value);
                tempList.Add(date);
            }
            sortedDates = tempList;
            sortedDates = sortedDates.OrderBy(u => u.Date);
            calendarHolidays.SelectedDates.AddRange(tempList.ToArray());
        }


    }
}
