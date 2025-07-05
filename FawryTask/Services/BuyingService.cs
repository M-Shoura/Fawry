using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FawryTask.Users;

namespace FawryTask.Services
{
    internal class BuyingService
    {
        public static void Buy(Customer customer)
        {
            if (customer.Cart is null || customer.Cart.items.Count == 0)
            {
                Console.WriteLine("Cart is Empty ! try adding items in cart first and try again");
                return;
            }

            if (customer.Cart.Total > customer.CurrentBalance)
            {
                Console.WriteLine("Cannot buy items because customer current balance is not enough !!");
            }
            else
            {
                customer.CurrentBalance -= customer.Cart.Total;
                Console.WriteLine($"Order Done Successfully. will be shipped on {DateTime.Now.Date.ToString("d")}");
                Console.WriteLine($"Current Customer Balance after order: {customer.CurrentBalance}");
            }
        }
    }
}
