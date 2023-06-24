namespace BuildinInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Training softwareTraining = new Training(120);
            //Training machineLTraining = new Training(120);

            // Console.WriteLine(softwareTraining.Equals(machineLTraining));

            List<int> numberList = new List<int> { 1, 2, 3, 4, 5 };
            int[] numberArray = new int[] { 1, 2, 6, 4 };
            TestIEnumerable.CollectionSum(numberList);

        }
    }
}