using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFour.Structural.Composite
{
    public class Leaf : IComponent
    {
        public Leaf(string name, int price)
        {
            Price = price;
            Name = name;

        }

        public int Price { get; set; }
        public string Name { get; set; }
        public void DisplayPrice()
        {
            Console.WriteLine($"\t Component Name:{Name} and Price:{Price}");
        }
    }
}
