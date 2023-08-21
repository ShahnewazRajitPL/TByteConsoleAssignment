﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartTwo.Prototype.ShallowVsDeep
{
    public class Address
    {
        public string City { get; set; }

        public Address GetClone()
        {
            return (Address)this.MemberwiseClone();
        }


    }
}
