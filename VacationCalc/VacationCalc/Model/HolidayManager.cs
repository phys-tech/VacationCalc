﻿using System;
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

        public HolidayManager()
        {
            LoadDatesFromXML();
        }

        public IEnumerable<DateTime> Holidays
        {
            get { return sortedDates; }
            set { sortedDates = value; }
        }

        public void SaveDatesToXML()
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
