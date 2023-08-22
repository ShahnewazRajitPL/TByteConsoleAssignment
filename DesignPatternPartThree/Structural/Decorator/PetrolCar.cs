﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartThree.Structural.Decorator
{
    public class PetrolCar : CarDecorator
    {
        public PetrolCar(ICar car) : base(car)
        {

        }

        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }

        public void AddEngine(ICar car)
        {
            if (car is BMWCar BMW)
            {
                BMW.Engine = "Petrol Engine";
                Console.WriteLine("Petrol engine Added to the Car:" + car);

            }
        }
    }
}
