using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFour.Structural.Bridge
{
    public static class ClientCodeForBridge
    {
        public static void UseBridgePattern()
        {
            AbstractRemoteController sonyRemoteController = new SonyTvAbstract(new SonyTv());
            sonyRemoteController.SwitchON();
            sonyRemoteController.SetChannel(401);
            sonyRemoteController.SwitchOFF();

            Console.WriteLine("Samsung TV");
            AbstractRemoteController samsungRemoteController = new SamsungTvAbstract(new SamsungTv());
            samsungRemoteController.SwitchON();
            samsungRemoteController.SetChannel(401);
            samsungRemoteController.SwitchOFF();
        }
    }
}
