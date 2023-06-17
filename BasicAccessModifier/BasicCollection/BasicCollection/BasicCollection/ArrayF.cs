using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCollection
{
    public class ArrayF
    {
        public static void AssignArray()
        {
            int[] array;

            array = new int[1];
            array[0] = 1;
            

            Console.WriteLine("array at index 2", array[0]);
            
        }

        public static void TakeUserInput()
        {
            int[] grades = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("array at index 5",grades[5]);
            string? input = Console.ReadLine();
            grades[5] = int.Parse(input!);
            Console.WriteLine("array at index 5->"+ grades[5]);
        }

        public static void ForEachArrayLoop()
        {
            int[] number = new int[10];

            for(int i =0;i<10;i++)
            {
                number[i] = i;
            }
            //for(int j=0;j<10;j++)
            //{
            //   Console.WriteLine("Element {0}={1} ", j, number[j]);
            //}

            int counter = 0;
            foreach(int item in number)
            {
                Console.WriteLine("Element {0}={1}", counter++, item);
            }
        }

        public static void multiDimensionalArray()
        {
            int[,] array2D = new int[,]
            {
                {1,2,3 },
                {4,5, 6 },
                {7,8, 9 }
            };
            Console.WriteLine("The value is {0}", array2D[0,0]);
        }

    }
}
