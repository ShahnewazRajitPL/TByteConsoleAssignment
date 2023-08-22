using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartThree.Structural.Facade
{
    public class CustomerRegistration
    {
        public bool RegisterCustomer(Customer customer)
        {
            Validator validator = new Validator();
            bool IsValid = validator.ValidateCustomer(customer);

            CustomerDataAccessLayer customerDataAccessLayer = new CustomerDataAccessLayer();
            bool IsSaved = customerDataAccessLayer.SaveCustomer(customer);

            Email email = new Email();
            email.SendRegistrationEmail(customer);

            return true;
        }
    }
}
