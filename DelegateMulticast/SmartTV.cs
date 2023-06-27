﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMulticast
{
    public class SmartTV
    {
        public string TvName { get; set; }

        public SmartTV(string tvName)
        {
            TvName = tvName;
            MachineManager.OnStartMachine += StartMachine;
            MachineManager.OnStopMachine += StopMachine;

        }

        private void StartMachine()
        {
            Console.WriteLine($"{TvName} has started!");

        }

        private void StopMachine()
        {
            Console.WriteLine($"{TvName} has stopped");
        }
    }
}
