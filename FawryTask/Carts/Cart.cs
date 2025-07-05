using FawryTask.Products;

namespace FawryTask.Carts
{
    internal class Cart
    {
        public List<CartItem> items;
        public decimal SubTotal => items.Sum(x => x.Product.Price);
        public decimal ShippingCost => 10;
        public decimal Total => ShippingCost + SubTotal;
        public Cart()
        {
            items = new List<CartItem>();
        }
        public void AddItem(Product product, int quantity)
        {
            foreach (var item in items)
            {
                if (item.Product.Name == product.Name)
                {
                    if (item.Product.QuantityInStock < quantity)
                        Console.WriteLine($"Not Enough Stock !! Cannot add {item.Product.Name} with Quantity {quantity}, available is {item.Product.QuantityInStock}");
                    else
                    {
                        item.OrderedQuantity += quantity;
                        item.Product.QuantityInStock -= quantity;
                    }
                    return;
                }
            }

            items.Add(new CartItem(product, quantity));
            foreach (var item in items)
            {
                if (item.Product.Name == product.Name)
                {
                    item.Product.QuantityInStock -= quantity;
                    if (item.Product.QuantityInStock < 0)
                    {
                        item.Product.QuantityInStock += quantity;
                        items.Remove(item);
                        Console.WriteLine($"Not Enough Stock !! Cannot add {item.Product.Name} with Quantity {quantity}, available is {item.Product.QuantityInStock}");
                        return;
                    }
                }
            }

        }
        public void RemoveItem(Product product, int quantity)
        {
            foreach (var item in items)
            {
                if (item.Product.Name == product.Name)
                {
                    item.OrderedQuantity -= Math.Min(quantity, item.OrderedQuantity);
                    item.Product.QuantityInStock += quantity;
                    return;
                }
            }
        }
    }
}
