using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Simple If else condition

            int voteCount = 150;
            // string result = null;

            /*if(voteCount>0)
            {
                result = "Won";

            }
            else
            {
                result = "Lost";
            }*/
            //var result = voteCount > 0 ? "Won" : "Lost";
            // Console.WriteLine($"You have {result}");

            //Multi-Nested If else
            //int number = 15;
            //string numberResult = null;

            /*if(number>0)
            {
                if(number % 2 == 0)
                {
                    numberResult = "Positive Even number";
                }
                else
                {
                    numberResult = "Positive Odd Number";
                }
            }
            else if (number < 0)
            {
                numberResult = "Negative Number";
            }
            else
            {
                numberResult = "Zero";
            }*/

            //var numberResult number > 10 ? number % 2 == 0 ? "Positive Even Number" : "Positive Odd Number" : number < 0 ? "Negitive Number" : "Zero";

            //Console.WriteLine($"Number {number} is {numberResult}");

            //Multi-branching

            //int score = 50;
            //string grade;

            /*if(score>=90)
            {
                grade = "Outstanding";
            }else if(score >=80)
            {
                grade = "Good";
            }else if(score >=70)
            {
                grade = "Average";
            }else if(score>=60)
            {
                grade = "Below Average";
            }
            else
            {
                grade = "Bad Performer";
            }

            Console.WriteLine($"You are {grade}");*/

            //var grade  = score >= 90 ? "Outstanding" : score >= 80 ? "Good" : score >= 70 ? "Average" : score >= 60 ? "Below Average" : "Bad Performer";
            //Console.WriteLine($"You are {grade}");

            //Null Coalescing
            int? myInt = null;

            string myName = "Shahnewaz";
            string myOtherName = myName ?? "Rajit";
            Console.WriteLine($"{myOtherName}");

            //loop //Repeat Operation
            //For, Foreach , Do, While

            //int a = 1;
            //for(;a<=10;a++)
            //{
               // Console.WriteLine(a);
            //}

            //Nesting 

            int a,b;
            for (a=2;a>=0;a--)
            {
                for (b=0;b<=2;b++)
                {
                    if(a==b)
                    {
                        Console.WriteLine("1");

                    }
                    else
                    {
                        Console.WriteLine("0");
                    }

                }

                Console.WriteLine("\n");
            }

            // String Reversal
            /* string myString = "Hello";
             string reversedString = "";

             for(int i = myString.Length-1; i>=0; i--)
             {
                 reversedString += myString[i];
             }

             Console.WriteLine(reversedString);*/

            //Foreach loop
            //Palindrones

            string[] wordCollection = { "madam", "mom", "level", "world", "racecar", "radar" };
            foreach(var word in wordCollection)
            {
                bool isPalindrome = true;
                for(int i=0; i<word.Length/2;i++)
                {
                    if ((word[i] != word[word.Length-1-i]))
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                Console.WriteLine($"{word} is {(isPalindrome ? " a plaindrome" :"not a palindome")}");

            }



        }
    }
}
