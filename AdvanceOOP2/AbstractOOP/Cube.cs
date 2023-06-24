using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOOP
{
    internal class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double len)
        {
            Length = len;
        }
        public override void GetVolumn()
        {
            Console.WriteLine("The Cube has a length" + Length);
        }
    }
}
