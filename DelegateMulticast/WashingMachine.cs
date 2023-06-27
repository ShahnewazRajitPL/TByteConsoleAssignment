using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DelegateMulticast
{
    public class WashingMachine
    {
        public WashingMachine(string wmName)
        {
            WmName = wmName;

            MachineManager.OnStartMachine += StartMachine;
            MachineManager.OnStopMachine += StopMachine;
        }

        public string WmName { get; set; }

        private void StartMachine()
        {
            Console.WriteLine($"{WmName} has started!");

        }

        private void StopMachine()
        {
            Console.WriteLine($"{WmName} has stopped");
        }

    }
}
