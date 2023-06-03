using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Testperformance
    {
        public void CheckPerformance()
        {
            const int Iterations = 100000;
            Stopwatch stopwatch = new Stopwatch();

            //Test Switch Statement
            stopwatch.Start();

            for(int i=0;i<Iterations; i++)
            {
                TestSwitch(5);
            }

            stopwatch.Stop();
            Console.WriteLine($"Switch statement time : {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();

            //Test if else statement
            
            stopwatch.Start();

            for (int i = 0; i < Iterations; i++)
            {
                TestIfElse(5);
            }

            stopwatch.Stop();
            Console.WriteLine($"If Else statement time : {stopwatch.ElapsedMilliseconds} ms");
        }

        public void TestSwitch(int number)
        {
            switch(number)
                {
                case 1:
                   // Console.WriteLine("");
                    break;
                case 2:
                    //Console.WriteLine("");
                    break;
                case 3:
                    //Console.WriteLine("");
                    break;
                case 4:
                    //Console.WriteLine("");
                    break;

                default:
                   // Console.WriteLine();
                    break;

                
            }
        }

        public void TestIfElse(int number)
        {
            if(number ==1)
            {
                //Console.WriteLine();
            }
            else if(number ==2)
            {
                //Console.WriteLine();
            }
            else if (number == 3)
            {
                //Console.WriteLine();
            }
            else if (number == 4)
            {
                //Console.WriteLine();
            }
            else
            {
                //Console.WriteLine();
            }

        }
    }
}
