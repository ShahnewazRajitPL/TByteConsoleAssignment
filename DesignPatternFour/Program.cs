using DesignPatternFour.Behavioral.Iterator;
using DesignPatternFour.Structural.Bridge;
using DesignPatternFour.Structural.Composite;
using DesignPatternFour.Structural.Proxy;

namespace DesignPatternFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ClientCodeForBridge.UseBridgePattern();

            //ClientForComposite.UseComposite();

            //ClientCodeForProxy.UseProxyPattern();

            ClientCodeForUsingIterator.UseIterator();
        }
    }
}