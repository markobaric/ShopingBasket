using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Products
{
    /// <summary>
    /// Base interface for all products
    /// </summary>
    public interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
    }
}
