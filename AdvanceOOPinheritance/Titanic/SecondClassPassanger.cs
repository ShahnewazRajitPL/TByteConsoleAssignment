using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanic
{
    internal class SecondClassPassanger : Passanger
    {
        public SecondClassPassanger(string name, int floorNo, int roomNo) : base(name, floorNo, roomNo)
        {
        }
    }
}
