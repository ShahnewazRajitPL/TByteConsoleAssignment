namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car bmw = new Car();
            Car audi = new Car();


            //bmw.SetCarName("bmw-fly");
            //Console.WriteLine(bmw.GetCarName());
            //audi.SetCarName("audi-fly");
            //Console.WriteLine(audi.GetCarName());

            bmw.Name = "bmw-fly";
            Console.WriteLine($"Getting Car name {bmw.Name}");
            bmw.Start();

            
            
            
            
            //Car marcedez = new Car();
            //bmw.Start();
            //audi.Start();
            //bmw.Speed();
            //audi.Speed();

            //bmw.CarDetails();
            //audi.CarDetails();

            // bmw.Start();
            //bmw color = Color.Red;
            //Console.WriteLine(bmw.color);

            //int bmw = Car.price;
            //bmw = 4;
            //Console.WriteLine(bmw);

            //bmw.Speed();

            //Car audi = new Car();
            //audi.Start();
            //audi.Speed();
        }
    }
}