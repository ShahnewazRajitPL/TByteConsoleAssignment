using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFour.Structural.Proxy
{
    public class Employee
    {
        public Employee(string userName, string role)
        {
            UserName = userName;
            Role = role;
        }
        public string UserName { get; set; }
        public string Role { get; set; }

        
    }
}
