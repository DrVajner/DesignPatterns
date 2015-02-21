using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class Report
    {
        public string ReportType { get; set; }
        private ArrayList _header = new ArrayList();
        private ArrayList _footer = new ArrayList();
        public void SetReportFooter(string data)
        {
            _header.Add(data);
        }
        public void SetReportHeader(string data)
        {
            _footer.Add(data);
        }
        public void DisplayReport()
        {
            foreach (var item in _header)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(ReportType);

            foreach (var item in _footer)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
