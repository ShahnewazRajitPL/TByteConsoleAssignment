using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartTwo.Prototype
{
    public class Students
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public string University { get; set; }

        public Students GetCloneStudents()
        {
            return (Students)this.MemberwiseClone();
        }

    }
}
