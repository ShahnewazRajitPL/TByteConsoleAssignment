using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedHasWagnar
{
    internal class M5 : BMW
    {
        public M5(int hP, string color, string model) : base(hP, color, model)
        {
        }

        public override void Repair()
        {
            base.Repair();
        }
    }
}
