namespace sampleMethodss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding Numbers");
            //var result = AddNumber(2, 4);
            //Console.WriteLine(result);
            var sum = new MethodWithoutArgument();
            var result1 = sum.AddNumberWithoutParameter();
            Console.WriteLine(result1);
            var result2 = sum.AddNumberWithConst();
            Console.WriteLine(result2);

            var convert = new ConvertToUpper();
            convert.NameToUpper();
        }

        static int AddNumber(int number1 , int number2)
        {
            return number1 + number2;
        }
    }
}