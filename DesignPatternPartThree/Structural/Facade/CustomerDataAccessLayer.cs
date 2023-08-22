using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartThree.Structural.Facade
{
    public class CustomerDataAccessLayer
    {
        public bool SaveCustomer(Customer customer)
        {
            Console.WriteLine("\nCustomer savedn into database...");
            return true;
        }
    }
}
