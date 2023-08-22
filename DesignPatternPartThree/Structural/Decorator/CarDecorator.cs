using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartThree.Structural.Decorator
{
    public abstract class CarDecorator : ICar
    {
        protected ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public ICar ManufactureCar()
        {
            return car.ManufactureCar();
            
        }
    }
}
