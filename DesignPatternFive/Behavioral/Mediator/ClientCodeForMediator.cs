using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFive.Behavioral.Mediator
{
    public static class ClientCodeForMediator
    {
        public static void UseMediator()
        {
            IFacebookMediator techByteFacebookGroup = new ConcreteFacebookGroupMediator();

            User poly = new ConcreteUser("Poly");
            User adil = new ConcreteUser("Adil");
            User labib = new ConcreteUser("Labib");
            User rajit = new ConcreteUser("Rajit");
            User moinul = new ConcreteUser("moinul");

            techByteFacebookGroup.RegisterUser(poly);
            techByteFacebookGroup.RegisterUser(adil);
            techByteFacebookGroup.RegisterUser(labib);
            techByteFacebookGroup.RegisterUser(rajit);
            techByteFacebookGroup.RegisterUser(moinul);

            poly.Send("I have added this group");
            Console.WriteLine();
            adil.Send("Hi There!");
            Console.Read();

        }
    }
}
