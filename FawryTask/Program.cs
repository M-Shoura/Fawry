using FawryTask.Products;
using FawryTask.Services;
using FawryTask.Users;

namespace FawryTask
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Adding Products and their number of items in stock :
            ScratchCard scratchCard = new ScratchCard(100);
            Cheese cheese = new Cheese(5);
            Biscuits biscuits = new Biscuits(15);
            Mobile mobile = new Mobile(1);
            TV tv = new TV(10);


            // Adding a Customer :
            Customer customer = new Customer("Mahmoud Shoura",2000);


            // Adding items in Customer's Cart with accepted quantity :
            customer.Cart.AddItem(cheese, 1);
            customer.Cart.AddItem(tv, 10);
            customer.Cart.AddItem(cheese, 3);
            customer.Cart.AddItem(scratchCard, 100);
            
            // Adding items in Customer's Cart with quantity more than in stock number of items :
            customer.Cart.AddItem(mobile, 2);


            // Removing items from Customer's Cart : 
            customer.Cart.RemoveItem(tv, 1);


            Console.WriteLine();
            // Showing Shipment package details (Shippable items only): 
            ShippingService.Checkout(customer.Cart);

            Console.WriteLine();

            // Showing Order Details (All items) :
            ReceiptService.GenerateReceipt(customer.Cart);

            Console.WriteLine();

            // Showing Customer's balance is insufficient or not : 
            BuyingService.Buy(customer);
        }
    }
}
