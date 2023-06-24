using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOP2
{
    internal class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Boow");
        }

        public void Move()
        {
            Console.WriteLine("Running  on four legs");
        }
    }
}
