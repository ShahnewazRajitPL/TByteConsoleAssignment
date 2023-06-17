using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAccessModifier
{
    public class  Bicycle :SellBicycle     {
        public Bicycle(int wheels)
        {
            Wheels = wheels;
        }

        public Bicycle()
        {
        }

        public int Wheels { get; set; }

        public void StartBicycle()
        {
            Console.WriteLine("Bicycle Started");
        }

        public void AttachedWheel()
        {
            Console.WriteLine($"You have attacheds {Wheels} wheels");
        }

        public void GenerateInvoice()
        {
            var bicycle = new Bicycle();
            bicycle.SetPrice(100);
            bicycle.Amount = 2;
            bicycle.GenerateInvoice();

        }
    }
}
