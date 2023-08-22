using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartThree.Structural.Decorator
{
    public static class ClientCodeForDecorator
    {
        public static void UseDecoratorCode()
        {
            ICar bmwCar1 = new BMWCar();
            ICar bmwCar2 = new BMWCar();

            //bmwCar1.ManufactureCar();
            //Console.WriteLine(bmwCar1 + "\n");

            DieselCar carWithDieselEngine = new DieselCar(bmwCar1);
            carWithDieselEngine.ManufactureCar();
            Console.WriteLine();

            PetrolCar carWithPetrolEngine = new PetrolCar(bmwCar1);
            carWithPetrolEngine.ManufactureCar();
            Console.WriteLine();
        }
    }
}
