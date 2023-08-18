using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartOne.AbstractFactory
{
    public  interface SportVehicleFactory
    {
        public IBike CreateBike();
        public ICar CreateCar();
    }
}
