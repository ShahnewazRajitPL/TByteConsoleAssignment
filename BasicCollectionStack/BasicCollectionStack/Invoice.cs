using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicCollections
{
    public class Invoice
    {
        public string? ProductName { get; set; }

        public int Amount { get; set; }

        public string? Email { get; set; }

        public double Total { get; set; }

        public Invoice(string productName, int amount, string email, double total)
        {
            ProductName = productName;
            Amount = amount;
            Email = email;
            Total = total;

        }
    }
}