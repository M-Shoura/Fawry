using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask.Products
{
    internal class ScratchCard : Product
    {
        public override string Name => "Scratch Card";
        public override decimal Price => 290;

        public ScratchCard(int q)
        {
            QuantityInStock = q;
        }
    }
}
