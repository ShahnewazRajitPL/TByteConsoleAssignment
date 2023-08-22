using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartThree.Structural.Facade
{
    public class ClientCodeForFacade
    {
        public static void WithoutFacade()
        {
            Customer customer = new Customer
            {
                Name ="Poly",
                Email="Poly@gmail.com"

            };

            CustomerRegistration customerRegistration = new CustomerRegistration();
            customerRegistration.RegisterCustomer(customer);
            
            
        }
    }
}
