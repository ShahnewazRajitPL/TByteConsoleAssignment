using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNamingConventionTypesNVariables
{
    internal class Program
    {
        //Start at here entry point
        //static void Main(string[] args)
       // {
            // int userAge;
            // userAge = 0;
            //Console.WriteLine(userAge);
            //Console.Read();

            /* int x = 10;
             int y= x;
             x = 20;
             Console.WriteLine("x" + x);
             Console.WriteLine("y" + y);
             Console.Read();*/

            /*int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array2 = array1;
            Console.WriteLine("array1[0]" + array1[0]);
            Console.WriteLine("array2[0]" + array2[0]);

            array1[0] = 10;
            Console.WriteLine("array1[0]" + array1[0]);
            Console.WriteLine("array2[0]" + array2[0]);
            Console.ReadKey();*/

            /*int number1 = 20;
            int number2 = 25;

            int sum = number1 + number2;
            Console.WriteLine("number1:{0}+ number2:{1}=sum {2}", number1, number2, sum);
            Console.ReadKey();*/

            /*float singlePrecision = 1.23345345345345f;
            double doublePrecision = 1.64546465436465d;
            decimal higherPrecision = 1.345345325345234m;

            Console.WriteLine("singlePrecision:{0},doublePrecision:{1},higherPrecision:{2}",singlePrecision,doublePrecision,higherPrecision);
            Console.ReadKey();*/
        //}
    }

    /*public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Friday,
        Saturday,
        Sunday,
    }

    public class DaysOfWeek
    {
        static void Main(string[] args)
        {
            DayOfWeek today = DayOfWeek.Saturday;
            Console.WriteLine("Today is " + today);

            if(today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
            {
                Console.WriteLine("It is the weeked");
            }
            else
            {
                Console.WriteLine("It is a weekday");
            }
            Console.Read();

        }

    }*/

    /*struct Point
    {
        public int x;
        public int y;

        public class Pointer
        {
            static void Main(string[] args)
            {
                Point p;
                p.x = 5;
                p.y = 10;

                Console.WriteLine("Point Coordinates: x:{0}, y:{1}", p.x, p.y);
                Console.Read();
            }
        }
    }*/

    public class BuildInTupple
    {
        static void Main(string[] args)
        {
            Tuple<int, string> person = new Tuple<int,string>(26,"Rajit");
            Console.WriteLine("Person:Age ={0}, Name ={1}", person.Item1, person.Item2);
            Console.Read();

        }
    }

}
