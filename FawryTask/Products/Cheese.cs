using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FawryTask.Interfaces;

namespace FawryTask.Products
{
    internal class Cheese : Product, IExpireable, IShippable
    {
        public Cheese(int q)
        {
            QuantityInStock = q;
        }

        public DateTime ExpireDate => DateTime.Now.AddDays(2);

        public override string Name => "Cheese";
        public override decimal Price => 25;

        public string GetName()
            => Name;

        public decimal GetWeight()
            => 0.3m;
    }
}
