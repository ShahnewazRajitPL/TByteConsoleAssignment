using System.Security.Cryptography.X509Certificates;

namespace DelegateMulticast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var smartTv = new SmartTV("Sony-Tv");
            var washingMachine = new WashingMachine("Walton-Wahingmachine");
            var oven = new Oven("Siemens-oven");
            //oven.StartMachine();
            //smartTv.StartMachine();
            //washingMachine.StartMachine();
            StartAllMachine();
            Console.Read();
            StopAllMachine();

            //smartTv.StopMachine();
            //washingMachine.StopMachine();
            //oven.StopMachine();

            
        }

        public static void StartAllMachine()
        {
            MachineManager.TriggerOnStart();

        }

        public static void StopAllMachine()
        {
            MachineManager.TriggerOnStop();

        }
    }
}