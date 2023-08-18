using DesignPatternPartOne.AbstractFactory;
using DesignPatternPartOne.Builder;
using DesignPatternPartOne.Factory;

namespace DesignPatternPartOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ClientCodeFactory.WithoutUsingFactoryCreditCard();

            //ClientCodeFactory.WithUsingFactoryCreditCard();

            ClientCodeForAbstractFactory.UseAbstractFactory();

            ClientCodeForUsingReport.UserBuilderCode();
        }
    }
}