using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFour.Structural.Bridge
{
    public class SamsungTvAbstract : AbstractRemoteController
    {
        public SamsungTvAbstract(ILEDTV ledTv)
        {
            this.ledTV = ledTv;
        }
        public override void SetChannel(int channelNumber)
        {
            ledTV.SetChannel(channelNumber);
        }

        public override void SwitchOFF()
        {
            ledTV.SwitchOff();
        }

        public override void SwitchON()
        {
            ledTV.SwitchOn();
        }
    }
}
