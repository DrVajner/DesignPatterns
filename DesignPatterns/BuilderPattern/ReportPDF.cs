using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class ReportPDF : ReportBuilder
    {
        public override void SetReportType()
        {
            Report.ReportType = "PDF Report";
        }

        public override void SetReportHeader()
        {
            Report.SetReportHeader("PDF Report Header");
        }

        public override void SetReportFooter()
        {
            Report.SetReportFooter("PDF Report Footer");
        }
    }
}
