using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAccessModifier
{
    internal class SellBicycle
    {
        private int _price;
        protected  int Amount { get; set; }

        protected void SetPrice(int price)
        {
            _price = price;
        }
        public void Invoice()
        {
            Console.WriteLine($"Your total is {_price * Amount}");
        }
    }
}
