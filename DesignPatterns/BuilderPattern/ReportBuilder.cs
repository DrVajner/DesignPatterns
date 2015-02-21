using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public abstract class ReportBuilder
    {
        protected Report Report { get; set; }
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportFooter();
        public void CreateNewReport()
        {
            Report = new Report();
        }
        public Report GetReport()
        {
            return Report;
        }
    }
}
