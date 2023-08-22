using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartThree.Structural.Adapter
{
    internal class Employee
    {
       
        public string Name { get; set; }
        
        public string Salary;

        public Employee( string name,  string salary)
        {
         
            Name = name;
           
            Salary = salary;
        }
    }
}
