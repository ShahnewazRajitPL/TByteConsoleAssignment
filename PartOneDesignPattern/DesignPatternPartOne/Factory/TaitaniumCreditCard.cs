using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartOne.Factory
{
    public class TaitaniumCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 600;
        }

        public string GetCardType()
        {
            return "Taitanium Credit Card";
        }

        public int GetCreditLimit()
        {
            return 15000000;
        }
    }
}
