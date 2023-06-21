using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicCollections
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public double Price { get; set; }

        public Product(int id, string name, double price)
        {
            Id = id;
            ProductName = name;
            Price = price;
        }
    }
}