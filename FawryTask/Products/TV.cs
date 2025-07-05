using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FawryTask.Interfaces;

namespace FawryTask.Products
{
    internal class TV : Product, IShippable
    {
        public override string Name => "TV";
        public override decimal Price => 1000;

        public TV(int q)
        {
            QuantityInStock = q;
        }

        public decimal GetWeight()
            => 10m;

        public string GetName()
            => Name;
    }
}
