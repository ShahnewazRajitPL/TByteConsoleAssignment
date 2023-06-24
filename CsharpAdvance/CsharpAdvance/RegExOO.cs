using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    public class RegExOO
    {
        public static void VerifyEmail()
        {
            string emailPattern = @" /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/";

            Regex regex = new Regex(emailPattern);

            string email = "rajitshahnewazpl@gmail.com";

            Match match = regex.Match(email);

            if(match.Success)
            {
                Console.WriteLine("Valid Email");

            }
            else
            {
                Console.WriteLine("Invaild Email");
            }

        }
    }
}
