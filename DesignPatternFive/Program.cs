using DesignPatternFive.Behavioral.ChainofResponsibility;
using DesignPatternFive.Behavioral.Mediator;
using DesignPatternFive.DepencyInjection;

namespace DesignPatternFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("\n Withdraw Money 4600");
             ClientCodeForChainOfResponsibility.UseChainOfRespo(4600);

             Console.WriteLine("\n Withdraw Money 45545");
             ClientCodeForChainOfResponsibility.UseChainOfRespo(45545); */

            //ClientCodeForMediator.UseMediator();

            ClientCodeInjector.UseInjectors();
        }
    }
}