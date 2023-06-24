using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOPinheritance
{
    public class Duck : BirdParent
    {
        

        public Duck(string name, string color, string diet):base(name, color, diet )
        {

        }

       /* public override void Fly()
        {
            Console.WriteLine($"{Name} can not fly");
            //base.Fly();
        }*/

    }
}
