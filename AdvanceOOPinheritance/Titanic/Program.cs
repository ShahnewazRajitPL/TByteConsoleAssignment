namespace Titanic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VipPassanger passanger1 = new VipPassanger("Jack", 10, 4);
            VipPassanger passanger2 = new VipPassanger("Rose", 9, 2);

            TitanicShip ship1 = new TitanicShip("Titanic", 200, 400000);

            ship1.SinkAllInside.Add(passanger1);
            ship1.SinkAllInside.Add(passanger2);

            ship1.Sink();
        }
    }
}