using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FawryTask.Carts;

namespace FawryTask.Users
{
    internal class Customer
    {
        public Customer(string name, decimal currentBalance)
        {
            Name = name;
            CurrentBalance = currentBalance;
            Cart = new Cart();
        }

        public string Name { get; set; }
        public decimal CurrentBalance { get; set; }
        public Cart Cart { get; set; }


    }
}
