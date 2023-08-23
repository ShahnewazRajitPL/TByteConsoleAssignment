using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFour.Structural.Proxy
{
    public class SharedFolder : ISharedFolder
    {
        public void PerformRWOperation()
        {
            Console.WriteLine("Performing Read Write operation");
        }
    }
}
