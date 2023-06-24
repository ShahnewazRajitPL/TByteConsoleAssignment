using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegate
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class DelegateO
    {
        public delegate bool FilterDelegate(Person person);
        public static void CheckDelegate()
        {
            List<string> list = new List<string>() { "Adil", "saif", "Walter", "Anatoli" };

            /*foreach (string s in list)
            {
                Console.WriteLine(s);
            }*/

            //list.RemoveAll(Filter);
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }

        public static void DelegateExample()
        {
            Person p1 = new Person() { Name = "Rajit", Age = 16 };
            Person p2 = new Person() { Name = "Labib", Age = 56 };
            Person p3 = new Person() { Name = "Adil", Age = 33 };
            Person p4 = new Person() { Name = "Sakib", Age = 20 };

            List<Person> personlist = new List<Person> { p1, p2, p3, p4 };

            DisplayPeople("KIDS", personlist, IsMinor);
        }

        public static void DisplayPeople(string title, List<Person> person, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person p in person)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0},{1} years old ", p.Name, p.Age);
                }
            }
        }

        public static bool IsAdult(Person person)
        {
            return person.Age >= 18;
        }

        public static bool IsSenior(Person person)
        {
            return person.Age >= 50;
        }

        public static bool IsMinor(Person person)
        {
            return person.Age < 18;
        }



        // public static bool Filter(string s)
        //{
        //  return s.Contains("i");
        // }
    }
}
