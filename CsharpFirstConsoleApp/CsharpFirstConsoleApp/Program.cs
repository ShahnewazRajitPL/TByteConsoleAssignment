using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please Enter Your Name");
            var takeName = System.Console.ReadLine();
            System.Console.WriteLine("Hello"+takeName);
            System.Console.WriteLine("--------------");
            System.Console.WriteLine("Please Enter Your Password");
            var password = System.Console.ReadLine();
            System.Console.WriteLine("Welcome"+password);
            System.Console.ReadKey();
        }
    }
}
