using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask.Products
{
    internal class Mobile : Product
    {
        public override string Name => "Mobile";
        public override decimal Price => 5000;

        public Mobile(int q)
        {
            QuantityInStock = q;
        }
    }
}
