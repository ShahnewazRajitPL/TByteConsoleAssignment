using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartOne.Factory
{
    public class ProductFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard creditCard = null;

            if(cardType == "Platinum")
            {
                creditCard = new PlatinumCreditCard();
            }
            else if (cardType == "Taitanium")
            {
                creditCard = new TaitaniumCreditCard();
            }
            else if (cardType == "Gold")
            {

            }


            return creditCard;

        }


    }
}
