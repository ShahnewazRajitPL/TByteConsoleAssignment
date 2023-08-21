using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartTwo.Prototype.ShallowVsDeep
{
    public class DhakaCampus : IStudents
    {
        public string Name { get ; set ; }
        public string Department { get ; set ; }
        public string University { get ; set ; }
        public Address Country { get; set; }

        public IStudents GetCloneStudent()
        {
            var students = (IStudents)this.MemberwiseClone();
            students.Country = Country.GetClone();
            return students;
        }

        public void ShowStudents()
        {
            Console.WriteLine("Dhaka campus student lists: : \n");
            Console.WriteLine("Name: {0}, Department {1}, University:{2}, Country:", Name, Department, University, Country.City);
        }

        public static void UseShallowVsDeepCopy()
        {
            var rajit = new DhakaCampus();
            rajit.Name = "Rajit";
            rajit.Department = "CSE";
            rajit.University = "IUB";
            rajit.Country = new Address { City = "Dhaka" };
            var jack = rajit.GetCloneStudent();
            jack.Name = "Jack";
            jack.Country.City = "CoxsBazar";

            rajit.ShowStudents();
            jack.ShowStudents();
        }
    }
}
