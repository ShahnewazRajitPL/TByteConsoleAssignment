using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DelegateMulticast
{
    public class Oven
    {
        public Oven(string ovenName)
        {
            OvenName = ovenName;
            MachineManager.OnStartMachine += StartMachine;
            MachineManager.OnStopMachine += StopMachine;
        }

        public string OvenName { get; set; }

        private void StartMachine()
        {
            Console.WriteLine($"{OvenName} has started!");

        }

        private void StopMachine()
        {
            Console.WriteLine($"{OvenName} has stopped");
        }
    }
}
