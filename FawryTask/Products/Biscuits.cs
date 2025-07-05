using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FawryTask.Interfaces;

namespace FawryTask.Products
{
    internal class Biscuits : Product, IExpireable
    {
        public override string Name => "Biscuits";
        public override decimal Price => 5;
        public DateTime ExpireDate => DateTime.Now.AddDays(5);

        public Biscuits(int q)
        {
            QuantityInStock = q;
        }
    }
}
