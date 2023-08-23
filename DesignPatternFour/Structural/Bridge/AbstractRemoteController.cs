using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFour.Structural.Bridge
{
    public abstract class AbstractRemoteController
    {
        protected ILEDTV ledTV;
        public abstract void SwitchON();
        public abstract void SwitchOFF();
        public abstract void SetChannel(int channelNumber);
    }
}
