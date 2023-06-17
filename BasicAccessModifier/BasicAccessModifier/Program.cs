

using newAccessModifier;

namespace BasicAccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Bicycle bicycle = new Bicycle();

            bicycle.Wheels = 3;
            bicycle.AttachedWheel();
            bicycle.StartBicycle();
            bicycle.GenerateInvoice();


        }
    }
}