using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciple.SRP
{
    public interface ILoggerSrp
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);

    }
}
