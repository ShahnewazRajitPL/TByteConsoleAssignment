using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    public class DateIO
    {
        public static void CheckDateClass()
        {
            //DateTime dateTime = new DateTime(2019, 5, 22);

            //Console.WriteLine(DateTime.UtcNow);

            DateTime now = DateTime.Now;
            DateTime tomorrow = GetTomorrow();

            Console.WriteLine(tomorrow.DayOfWeek);

            Console.WriteLine("Write your bdate like this formate : yyyy-mm-dd");



            var userInput = Console.ReadLine() ?? "1995-11-01";

            var lifeSpan = GetTotalBirthDayCount(userInput);

            if(lifeSpan >0)
            {
                Console.WriteLine($"You have lived  {lifeSpan} days");
            }
            else
            {
                Console.WriteLine("Please enter the correct formates");
            }
        }

        public static DateTime GetTomorrow()
        {
            return DateTime.Now.AddYears(-1);

        }

        public static int GetTotalBirthDayCount(string input)
        {
            DateTime now = DateTime.Now;
            DateTime dateTime;

            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan days = now.Subtract(dateTime);
                return days.Days;

            }
            else
            {
                return 0;
            }
        }
    }
}
