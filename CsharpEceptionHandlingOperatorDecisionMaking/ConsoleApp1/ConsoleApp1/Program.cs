using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testPerformance = new Testperformance();
            testPerformance.CheckPerformance();
            //int number1 = 95;
            //int number2 = 4;

            //int addition = number1 + number2;
            //int multiplication = number1 * number2;
            // int division = number1 / number2;
            //int subtraction = number1 - number2;
            // int modulus = number1 % number2;

            // Console.WriteLine($"addition: {addition} \n Multiplication:{multiplication}\n Division: {division}\n" + $"subtraction:{subtraction}\n Modulus: {modulus}");


            //var num1 = 4;
            //var num2 = 6;
            //var num3 = 8;
            //var num4 = 3;
            //var num5 = 2;

            //var checkPrecedence = num1 + num2 * (num3 / num4) / num5;
            // Console.WriteLine($"Test Precedence: {checkPrecedence}");
            //BOOMAS

            //Unary Operators

            //int x = 5;
            //int y = -x;
            //int z = ++x;
            //Console.WriteLine($"Y:{y},Z: {z}");

            //Conditional Operators

            //int a = 10;
            //int b = 20;
            //Console.WriteLine(a>b);
            //Console.WriteLine(a<b);
            //Console.WriteLine(a>=b);
            //Console.WriteLine(a<=b);
            //Console.WriteLine(a==b);
            //Console.WriteLine(a!=b);

            //Bitwise Operators

            //int c = 5;
            //int d = 3;

            //int resultAndBitwise = c & d;
            // Console.WriteLine(resultAndBitwise);

            // String myName = "Shahnewaz";
            //string myOtherName = "Rajit";

            //Console.WriteLine(myName == myOtherName && myName != myOtherName);

            //TRY Catch Finally

            //int x = 5;
            //int y = 0;
            //int division = x / y;

            /* try
             {
                 Console.WriteLine("Enter the first number:");
                 int num1 = int.Parse(Console.ReadLine());

                 Console.WriteLine("Enter the second number:");
                 int num2 = int.Parse(Console.ReadLine());

                 int result = num1 / num2;
                 Console.WriteLine("Result :" + result);

             }
             catch(DivideByZeroException ex)
             {
                 Console.WriteLine($"Error: Divisionby zero is not allowed. {ex.Message}");
             }

             finally
             {
                 Console.WriteLine("Finally Done!");
             }*/

            //if else

            //int num = 10;

           /* if (num >= 0)
            {
                Console.WriteLine("Positive Number");
                if (num % 2 == 0)
                {
                    Console.WriteLine("Number is even");
                }
                else
                {
                    Console.WriteLine("Number is odd");

                }

            }
            else

            { Console.WriteLine("Negative"); }*/


            //if else if

            /*if (num == 5)
            {
                Console.WriteLine("Number 5");

            }
            else if(num == 6)
            {
                Console.WriteLine("Number 6");
            }
            else if(num ==10)
            {
                Console.WriteLine("Number 10");
            }
            else
            {
                Console.WriteLine("Number 11");
            }


            switch(num)
            {
                case 0:
                    Console.WriteLine("Num0");
                    break;
                case 1:
                    Console.WriteLine("Num0");
                    break;
                case 2:
                    Console.WriteLine("Num0");
                    break;
                case 3:
                    Console.WriteLine("Num0");
                    break;
                default:
                    Console.WriteLine();
                    break;

            }*/

        }
            
    }
}
