using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartOne.Builder
{
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportType();
            reportBuilder.SetReportFooter();
            reportBuilder.SetReportContent();
            return reportBuilder.GetReport();

        }
    }
}
