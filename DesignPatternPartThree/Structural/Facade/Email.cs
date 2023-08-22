using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartThree.Structural.Facade
{
    public class Email
    {
        public bool SendRegistrationEmail(Customer customer)
        {
            Console.WriteLine("Registration Email Send");
            return true;
        }
    }
}
