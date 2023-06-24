using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOP2
{
    internal class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public void Move()
        {
            Console.WriteLine("Jumping and Climbing");
        }
    }
}
