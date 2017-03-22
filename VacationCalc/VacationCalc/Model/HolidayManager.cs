using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace VacationCalc.Model
{
    public class HolidayManager
    {
        private IEnumerable<DateTime> sortedDates;
        private string XmlFilename = "Holidays.xml";
        public event EventHandler HolidaysChanged;        

        public HolidayManager()
        {
            LoadDatesFromXML();
        }

        public IEnumerable<DateTime> Holidays
        {
            get { return sortedDates; }
        }

        public void SetNewDates(IEnumerable<DateTime> newDates)
        {
            sortedDates = newDates;
            sortedDates = sortedDates.OrderBy(u => u.Date);
            //System.Console.WriteLine("HolidayManager.SetNewDates() - firing an event");
            OnHolidaysChanged(null);
            SaveDatesToXML();
        }

        protected virtual void OnHolidaysChanged(EventArgs e)
        {
            EventHandler handler = HolidaysChanged;
            if (handler != null)
                handler(this, e);
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
        }
    }
}
