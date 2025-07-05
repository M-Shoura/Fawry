using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FawryTask.Carts;
using FawryTask.Interfaces;

namespace FawryTask.Services
{
    internal class ShippingService
    {
        public static void Checkout(Cart cart)
        {
            if (cart is null || cart.items.Count == 0)
            {
                Console.WriteLine("Cart is Empty ! try adding items in cart first and try again");
                return;
            }


            decimal Total_Weight = 0;
            Console.WriteLine("** Shipment notice **");
            foreach (var item in cart.items)
            {
                if (item.Product is IShippable)
                {
                    var shipItem = (IShippable)item.Product;
                    Console.WriteLine($"{item.OrderedQuantity}x  {item.Product.Name}      {shipItem.GetWeight() * item.OrderedQuantity} kg");
                    Total_Weight += shipItem.GetWeight() * item.OrderedQuantity;
                }
            }
            Console.WriteLine($"Total Package Weight : {Total_Weight} kg");

        }


    }
}
