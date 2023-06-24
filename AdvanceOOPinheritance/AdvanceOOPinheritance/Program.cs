namespace AdvanceOOPinheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck1 = new Duck("Donald","Red","Seeds");
            Duck duck2 = new Duck("Harry", "Black", "SeedsAll");
            duck1.Eat();
            duck2.Eat();
            duck1.Fly();
            duck2.Fly();
            duck1.FlyBird();
        }
    }
}