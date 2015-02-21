using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class Director
    {
        public Report MakeReport(ReportBuilder builder)
        {
            builder.CreateNewReport();
            builder.SetReportType();
            builder.SetReportHeader();
            builder.SetReportFooter();
            return builder.GetReport();
        }
    }
}
