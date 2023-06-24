using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanic
{
    public class TitanicShip : WaterCraft , ISinkable
    {
        public List<ISinkable>SinkAllInside { get; set; }
        public TitanicShip(string name, int length, int passengerCapacity) : base(name,length,passengerCapacity)
        {
            SinkDuration = passengerCapacity - 10;
            SinkAllInside = new List<ISinkable>();
        }

        public int SinkDuration { get ; set ; }

        public void Sink()
        {
            Console.WriteLine($"The watercraft {Name} is sinking , which is {Length} units big.");
            Console.WriteLine($"The watercraft {Name} will sink in {SinkDuration} minitues.");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Now everything inside {Name} will sink.");

            foreach (ISinkable item in SinkAllInside)
            {
                item.Sink();
            }
        }
    }
}
