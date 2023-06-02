using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleMethodss
{
    public class ConvertToUpper
    {
        public void NameToUpper()
        {
            string takeInput = null;
            Console.WriteLine("Please type your name and press enter: ");

                takeInput = Console.ReadLine();
            int tryPass = 0;

            while(Int32.TryParse(takeInput, out tryPass))
            {
                Console.WriteLine("Please type string value");
                takeInput = Console.ReadLine();

            }

            string myNameUpperCase = null;
            if (!string.IsNullOrWhiteSpace(takeInput))
            {
                myNameUpperCase = takeInput.ToUpper();
                Console.WriteLine($"You converted name to upper {myNameUpperCase}");
            }
            else
            {
                Console.WriteLine("You have added an empty value"); 
            }
        }

    }
}
