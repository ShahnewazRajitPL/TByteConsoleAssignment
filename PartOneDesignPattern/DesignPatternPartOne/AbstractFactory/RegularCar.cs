using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartOne.AbstractFactory
{
    internal class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Regular Car Details...");
        }
    }
}
