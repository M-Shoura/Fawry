using FawryTask.Products;

namespace FawryTask.Carts
{
    internal class CartItem
    {
        public Product Product { get; set; }
        public int OrderedQuantity { get; set; }

        public CartItem(Product product, int orderedQuantity)
        {
            Product = product;
            OrderedQuantity = orderedQuantity;
        }
    }
}
