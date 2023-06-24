using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SealedHasWagnar
{
    public class BMW : Car
    {
        private string brand = "BMW";

        public string Model { get; set; }
        public BMW(int hP,string color, string model) : base(hP, color)
        {
            this.Model = model;
        }

        public override void Repair()
        {
            Console.WriteLine($"This  {brand} was repaired");
        }
    }
}
