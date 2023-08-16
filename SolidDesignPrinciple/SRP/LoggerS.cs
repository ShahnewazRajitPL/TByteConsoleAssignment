using SolidDesignPrinciple.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciple.SEP
{
    public class LoggerS : ILoggerSrp
    {
        public void Debug(string info)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(info);
        }

        public void Error(string message, Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message, ex.ToString());
        }

        public void Info(string info)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(info);
        }
    }
}
