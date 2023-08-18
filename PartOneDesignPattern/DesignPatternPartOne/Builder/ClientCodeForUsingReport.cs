using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartOne.Builder
{
    public static class ClientCodeForUsingReport
    {
        public static void UserBuilderCode()
        {
            Console.WriteLine("Creating PDF....");
            PDFReport pdfReport = new PDFReport();
            ReportDirector reportDirector = new ReportDirector();

            Report report = reportDirector.MakeReport(pdfReport);

            report.DisplayReport();

            Console.WriteLine("\n................\n");
            Console.WriteLine("Creating Excel......");
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);

            report.DisplayReport();

        }
    }
}
