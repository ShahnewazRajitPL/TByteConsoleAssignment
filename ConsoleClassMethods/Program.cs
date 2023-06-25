namespace ConsoleClassMethods
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello World");
            Console.WriteLine("Display and puts the carser in the line");
            Console.Write("Hello Universe");
            Console.ReadKey();
            //Console.Clear();
            Console.Read();
        }
    }*/

    //Naming convention 

    /*public class ProductCasting
    {
        static void Main(String[]args)
        {
            double myOwnDoubleAge = 13.27;
            int myIntAge;

            //Explicit Conversion
            myIntAge = (int)myOwnDoubleAge;

            //String to Integer
            string myStringAge = "18";

            int num1 = 4;
            int num2 = 6;
            Console.WriteLine(num1 + num2);

            String number1 = "4";
            String number2 = "6";

            int numInt1 = Int32.Parse(number1);
            int numInt2 = Int32.Parse(number2);

            Console.WriteLine(number1 + number2);
            //int myAge = Int32.Parse(myStringAge);
            //Console.WriteLine(myAge);
            Console.Read();

        }
    }*/

    public class StringManipulation
    {
        static void Main(String[]args)
        {
            int myAge = 42;
            string myName = "Rajit";
            string myJob = "SS";

            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hey! It is " + myName+ " I am "+myAge+ "years old.I am working as a "+myJob);

            Console.WriteLine("String Indexing format");
            Console.WriteLine("Hello!,My name is {0}, I am {1} years old working as {2}", myName, myAge, myJob);

            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello! My name is {myName}, I am {myAge} years old .Working as {myJob}");

            Console.WriteLine("Verbal String");
            Console.WriteLine(@"E:\TByteAllAssignment\CsharpBasicMoreTypes\ConsoleClassMethods");

            Console.WriteLine(myName.ToLower());
            Console.WriteLine(myName.Trim());
            Console.WriteLine(myName.IndexOf("R"));

        }
    }

    
}