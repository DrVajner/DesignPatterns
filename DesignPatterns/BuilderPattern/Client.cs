using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    class Client : IClient
    {
        public void DoSomething()
        {
            Report report = null;
            var director = new Director();

            var reportPdf = new ReportPDF();
            report = director.MakeReport(reportPdf);
            report.DisplayReport();

            var reportExcel = new ReportExcel();
            report = director.MakeReport(reportExcel);
            report.DisplayReport();
        }
    }
}
