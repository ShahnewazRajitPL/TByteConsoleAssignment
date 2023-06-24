namespace SealedHasWagnar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Audi(400, "Black", "A4"),
                new BMW(500,"Red","M3")
            };

            /*foreach(var car in cars)
            {
                car.Repair();
                car.ShowDetails();
            }*/

            Audi audi = new Audi(450, "White", "M5");
            audi.ShowDetails();

            audi.SetCarInfo(45542, "Wagnar");
            audi.GetCarInfo();
        }
    }
}