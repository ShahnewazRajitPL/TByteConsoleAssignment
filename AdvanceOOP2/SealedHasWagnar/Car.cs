using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedHasWagnar
{
    public class Car
    {
        public Car(int hP, string color)
        {
            HP = hP;
            Color = color;
        }

        //Has a relationship

        CarInfo carIfo = new CarInfo();

        public void SetCarInfo(int lNo, string owner)
        {
            carIfo.LicenseNo = lNo;
            carIfo.OwnerName = owner;
        }

        public void GetCarInfo()
        {
            Console.WriteLine($"The car has the license No {carIfo.LicenseNo} and is owned by {carIfo.OwnerName}");
        }

        public int HP { get; set; }
        public string Color { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("HP {0} , Color: {1}", HP, Color);

        }

        public virtual void Repair()
        {
            Console.WriteLine("Car has repaired");
        }
    }
}
