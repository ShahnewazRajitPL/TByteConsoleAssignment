using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciple
{
    public class OrangeDerivedClassL: AppleBaseClass
    {
        public override string GetColor()
        {
            return "Orange";
        }

    }
}
