using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask.Products
{
    internal abstract class Product
    {
        public abstract string Name { get; }
        public abstract decimal Price { get; }
        public int QuantityInStock { get; set; }

    }
}
