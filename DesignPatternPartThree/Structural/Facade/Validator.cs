using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartThree.Structural.Facade
{
    public class Validator
    {
        public bool ValidateCustomer(Customer customer)
        {
            Console.WriteLine("Customer Validated.....");
            Console.WriteLine("Name:{0}", customer.Name);
            Console.WriteLine("Name:{1}", customer.Email);

            return true;
        }
    }
}
