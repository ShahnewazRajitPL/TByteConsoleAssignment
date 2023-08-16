using SolidDesignPrinciple.LiSK;
using SolidDesignPrinciple.OpenClosed;

namespace SolidDesignPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var invoice = new InvoiceS("DummayName", "DummyDescription", 4);
            //invoice.AddInvoice();

            //var amount = InvoiceOC.GetInvoiceDiscount(4000, InvoiceType.FinalInvoice);
            //Console.WriteLine(amount);

            // InvoiceOP fiInvoice = new FinalInvoice();
            //double finalInvoiceAmount = fiInvoice.GetInvoiceDiscount(500);
            // Console.WriteLine("Fianl Invoice amount: {0}", finalInvoiceAmount);

            //AppleBaseClass apple = new OrangeDerivedClassL();
            //Console.WriteLine(apple.GetColor());

            IFruit fruits = new Apple();

            Console.WriteLine(fruits.GetColor());

            fruits = new Orange();

            Console.WriteLine(fruits.GetColor());


        }
    }
}