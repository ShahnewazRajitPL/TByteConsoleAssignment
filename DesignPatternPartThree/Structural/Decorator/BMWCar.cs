using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartThree.Structural.Decorator
{
    public class BMWCar : ICar
    {
        private string CarName = "BMW";

        public string CarBody { get; set; }
        public string Engine { get; set; }
        public ICar ManufactureCar()
        {
            CarBody="Carbon Fiber Material";
            return this;
        }

        public override string ToString()
        {
            return "BMWcar [CarName"+ CarName+",CarBody = "+ CarBody +", Car Engine = "+Engine+"]";
        }

    }
}
