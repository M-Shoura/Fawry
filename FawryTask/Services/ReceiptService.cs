using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FawryTask.Carts;

namespace FawryTask.Services
{
    internal class ReceiptService
    {
        public static void GenerateReceipt(Cart cart)
        {
            if (cart is null || cart.items.Count == 0)
            {
                Console.WriteLine("Cart is Empty ! try adding items in cart first and try again");
                return;
            }

            Console.WriteLine("** Checkout receipt **");
            foreach (var item in cart.items)
            {
                Console.WriteLine($"{item.OrderedQuantity}x  {item.Product.Name}     {item.Product.Price}");
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Subtotal: {cart.SubTotal}");
            Console.WriteLine($"Shipping Cost: {cart.ShippingCost}");
            Console.WriteLine($"Amount: {cart.ShippingCost + cart.SubTotal}");
        }
    }
}
