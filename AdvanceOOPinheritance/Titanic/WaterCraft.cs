using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanic
{
    public class WaterCraft
    {
        public WaterCraft(string name, int length, int passengerCapacity)
        {
            Name = name;
            Length = length;
            PassengerCapacity = passengerCapacity;
        }

        public string Name { get; set; }
        public int Length { get; set; }

        public int PassengerCapacity { get; set; }

        public void StartEngine()
        {
            Console.WriteLine($"{Name} has started");
        }

        public void StopEngine()
        {
            //Code to stop the engine
            Console.WriteLine($"{Name} has stopped");
        }


    }
}
