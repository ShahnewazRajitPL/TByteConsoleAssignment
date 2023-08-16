using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciple.OpenClosed
{
    public class InvoiceOP
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return -10;
        }
    }
}
