using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAccessModifier
{
    public static class BaseClass
    {
        public static int count { get; set; }

        static BaseClass()
        {
            count = 0;
        }
    }
}
