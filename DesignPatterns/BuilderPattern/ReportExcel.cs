using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class ReportExcel : ReportBuilder
    {
        public override void SetReportType()
        {
            Report.ReportType = "Excel report";
        }

        public override void SetReportHeader()
        {
            Report.SetReportHeader("Excel report Header");
        }

        public override void SetReportFooter()
        {
            Report.SetReportFooter("Excel report Footer");
        }
    }
}
