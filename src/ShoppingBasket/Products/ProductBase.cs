using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Products
{
    /// <summary>
    /// Base implementation for all products
    /// </summary>
    public abstract class ProductBase : IProduct
    {
        public ProductBase(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
