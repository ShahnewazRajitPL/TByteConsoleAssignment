using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciple.SRP
{
    public class Email
    {
        public string EMailForm { get; set; }

        public string EMailTo { get; set; }
        public string EMailSubject { get; set; }
        public string EMailBody { get; set; }

        public void SendEmail(MailMessage mailMessage)
        {
            try
            {
                Console.WriteLine("Email is sending");

                Console.WriteLine("Email has sent");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }
    }
}
