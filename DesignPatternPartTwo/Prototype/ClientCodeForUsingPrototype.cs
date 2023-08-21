using DesignPatternPartTwo.Prototype.ShallowVsDeep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartTwo.Prototype
{
    public static class ClientCodeForUsingPrototype
    {
        public static void UseWithoutPrototype()
        {
            Students rajit = new Students();
            rajit.Name = "Rajit";
            rajit.Department = "CSE";
            rajit.University = "IUB";

            Students jack = rajit;
            jack.Name = "Jack";

            Console.WriteLine("Rajit");

            Console.WriteLine("Name: {0},Department: {1}, University:{2}", rajit.Name, rajit.Department, rajit.University);

            Console.WriteLine("Jack");
            Console.WriteLine("Name: {0},Department: {1}, University:{2}", jack.Name,jack.Department,jack.University);


        }

        public static void UseWithPrototype()
        {
            Students rajit = new Students();
            rajit.Name = "Rajit";
            rajit.Department = "CSE";
            rajit.University = "IUB";
            

            Students jack = rajit.GetCloneStudents();
            jack.Name = "Jack";

            Students rose = rajit.GetCloneStudents();
            rose.Name = "Rose";

            Students labeeb = rajit.GetCloneStudents();
            labeeb.Name = "Labeeb";
            labeeb.University = "UIU";

            Console.WriteLine("Rajit");

            Console.WriteLine("Name: {0},Department: {1}, University:{2}", rajit.Name, rajit.Department, rajit.University);

            Console.WriteLine("Jack");
            Console.WriteLine("Name: {0},Department: {1}, University:{2}", jack.Name, jack.Department, jack.University);

            Console.WriteLine("Rose");
            Console.WriteLine("Name: {0},Department: {1}, University:{2}", rose.Name, rose.Department, rose.University);

            Console.WriteLine("Labeeb");
            Console.WriteLine("Name: {0},Department: {1}, University:{2}", labeeb.Name, labeeb.Department, labeeb.University);


        }

        public static void UseShallowCopy()
        {
            var rajit = new DhakaCampus();
            rajit.Name = "Rajit";
            rajit.Department = "CSE";
            rajit.University = "IUB";
            rajit.Country = new Address { City = "Dhaka" };
            var jack = rajit.GetCloneStudent();
            jack.Name = "Jack";
            jack.Country.City =  "CoxsBazar" ;

            rajit.ShowStudents();
            jack.ShowStudents();
        }
    }
}
