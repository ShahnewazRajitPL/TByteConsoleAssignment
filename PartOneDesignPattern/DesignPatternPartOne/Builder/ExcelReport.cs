﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartOne.Builder
{
    public class ExcelReport: ReportBuilder
    {
        
        public override void SetReportContent() => reportObject.ReportContent = "Excel Content";



        public override void SetReportFooter() => reportObject.ReportFooter = "Excel Footer";



        public override void SetReportHeader() => reportObject.ReportHeader = "Excel Header";



        public override void SetReportType() => reportObject.ReportType = "Excel";



    

}
}
