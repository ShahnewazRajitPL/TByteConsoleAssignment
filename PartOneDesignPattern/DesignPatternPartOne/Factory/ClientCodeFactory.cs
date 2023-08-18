using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartOne.Factory
{
    public static class ClientCodeFactory
    {
        public static void WithUsingFactoryCreditCard()
        {
            ICreditCard getPlatinumCreditCard = ProductFactory.GetCreditCard("Platinum");

            if (getPlatinumCreditCard != null)
            {
                Console.WriteLine("CardType: {0}", getPlatinumCreditCard.GetCardType());
                Console.WriteLine("CardLimit:{0}", getPlatinumCreditCard.GetCreditLimit());
                Console.WriteLine("AnnualCharge: {0}", getPlatinumCreditCard.GetAnnualCharge());

            }
            else
            {
                Console.WriteLine("Invalid card type");
            }
        }


        public static void WithoutUsingFactoryCreditCard()
        {
            string cardType = "Platinum";
            ICreditCard creditCard = null;

            if(cardType == "Platinum")
            {
                creditCard = new PlatinumCreditCard();
            }else if(cardType == "Taitanium")
            {
                creditCard = new TaitaniumCreditCard();
            }else if(cardType =="Gold")
            {

            }
            else
            {
                //default
            }

            if(creditCard != null)
            {
                Console.WriteLine("CardType: {0}", creditCard.GetCardType());
                Console.WriteLine("CardLimit:{0}", creditCard.GetCreditLimit());
                Console.WriteLine("AnnualCharge: {0}", creditCard.GetAnnualCharge());

            }
            else
            {
                Console.WriteLine("Invalid card type");
            }
        }
    }
}
