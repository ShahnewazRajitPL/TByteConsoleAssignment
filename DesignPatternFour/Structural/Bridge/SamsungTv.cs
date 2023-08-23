using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFour.Structural.Bridge
{
    public class SamsungTv : ILEDTV
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting Channel Number"+channelNumber+"On Sony Tv");

        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning Off: Sony Tv");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Turning ON: Sony Tv");
        }
    }
}
