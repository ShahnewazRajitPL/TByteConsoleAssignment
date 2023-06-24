using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanic
{
    internal class VipPassanger : Passanger, ISinkable
    {
        public VipPassanger(string name, int floorNo, int roomNo) : base(name, floorNo, roomNo)
        {
            SinkDuration = 15;
        }

        public int SinkDuration { get ; set ; }

        public void Sink()
        {
            Console.WriteLine($"The VIP {Name} is sinking , who was on floor {FloorNo} in room {RoomNo}.");
            Console.WriteLine($"It will take {SinkDuration} minitues for the VIP {Name} to sink.");
            Console.WriteLine($"The VIP {Name} is now decreased.");
        }
    }
}
