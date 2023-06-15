using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopAndOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //palindrome

            //String[] wordCollection = { "level", "hello", "dad", "world" };
            //foreach(var item in wordCollection)
            // {
            /*for(int i=0;i< item.Length/2;i++)
            {
                if (item[i] != item.Length-1-i)
                {

                }
            }
            item == item*/

            //bool isPalindrome = item.SequenceEqual(item.Reverse());

            //Console.WriteLine($"{item} is {(isPalindrome ? "a palindrome" : "not a palindrome")}");

            //}

            //Break & Continue

            /*for(int counter=0;counter<10;counter++)
            {
                if(counter%2==0)
                {
                    Console.WriteLine("Next number is odd number.");
                    continue;
                }
                Console.WriteLine(counter);
            }*/

            //while loop
            //Integer reversal

            int number = 123456;
            int reverseNumber = 0;
            while(number!=0)
            {
                int reminder = number % 10;
                Console.WriteLine("reminder"+reminder);
                reverseNumber = reverseNumber * 10 + reminder;

                Console.WriteLine("reverseNumber"+reverseNumber);
                number /= 10;
            }

            int num = 1;
            do
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if(num%3 ==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(num%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(num);

                }
                num++;
            } while (num <= 100);

        }
    }
}
