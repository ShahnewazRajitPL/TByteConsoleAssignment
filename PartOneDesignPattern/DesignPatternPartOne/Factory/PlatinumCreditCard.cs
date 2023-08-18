using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartOne.Factory
{
    public class PlatinumCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "Platinum Credit Card";
        }

        public int GetCreditLimit()
        {
            return 16000000;
        }
    }
}
