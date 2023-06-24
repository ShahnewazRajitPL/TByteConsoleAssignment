using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOP2
{
    internal class Bird : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Chirp!");
        }

        public void Move()
        {
            Console.WriteLine("Flying in the sky.");
        }
    }
}
