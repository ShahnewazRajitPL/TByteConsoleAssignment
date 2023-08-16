using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciple.OpenClosed
{
    public class ProposedInvoice: InvoiceOP
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 60;

        }

    }
}
