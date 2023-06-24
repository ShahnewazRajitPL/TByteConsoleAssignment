namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read File

            //string text = System.IO.File.ReadAllText(@"E:\TByteAllAssignment\AdvanceOOP2\AdvanceOOP2\FileIO\test.txt");
            // Console.WriteLine(text);

            /* string[] text = System.IO.File.ReadAllLines(@"E:\TByteAllAssignment\AdvanceOOP2\AdvanceOOP2\FileIO\test.txt");

             foreach(var item in text)
             {
                 Console.WriteLine(text);


             }*/

            //Write
            //string[] wordCollection = { "200", "300", "400" };
            //File.WriteAllLines(@"E:\TByteAllAssignment\AdvanceOOP2\AdvanceOOP2\FileIO\test1.txt",wordCollection);

            string userInput = Console.ReadLine() ?? "Default";

            //File.WriteAllText(@"E:\TByteAllAssignment\AdvanceOOP2\AdvanceOOP2\FileIO\test2.txt", userInput);

            using (StreamWriter file = new StreamWriter(@"E:\TByteAllAssignment\AdvanceOOP2\AdvanceOOP2\FileIO\test3.txt")) 
            {
                file.WriteLine(userInput);
            }

        }
    }
}