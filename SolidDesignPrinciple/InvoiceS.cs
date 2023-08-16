using SolidDesignPrinciple.SEP;
using SolidDesignPrinciple.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciple
{
    public class InvoiceS
    {
        public string InvoiceName { get; set; }
        
        public string InvoiceDescription { get; set; }

        public int OrderId { get; set; }
        private Email emailSender;
        private ILoggerSrp logger;

        public InvoiceS(string invoiceName, string invoiceDescription, int orderId)
        {
            InvoiceName = invoiceName;
            InvoiceDescription = invoiceDescription;
            OrderId = orderId;
            this.emailSender = new Email();
            this.logger = new LoggerS();
        }

        public void AddInvoice()
        {
            try
            {
                this.logger.Info("Your Invoice is creating");
                if(!string.IsNullOrEmpty(InvoiceName))
                {
                    this.logger.Info("Invoice is read to send");
                }

                MailMessage nullMessage = new MailMessage("EmailForm", "EmailTo", "Invoice", "YourInvoiceBody");
                this.emailSender.SendEmail(nullMessage);

                
            }
            catch(Exception ex)
            {
                this.logger.Error("Error", ex);
            }
        }

        public void deleteInvoice()
        {
            try
            {
                this.logger.Info("Your Invoice is Deleting");
                if (string.IsNullOrEmpty(InvoiceName))
                {
                    this.logger.Info("Invoice is deleted");
                }
               
            }
            catch(Exception ex)
            {
                this.logger.Error("Error",ex);


            }
        }

       

    }
}
