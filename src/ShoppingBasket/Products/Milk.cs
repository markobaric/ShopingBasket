using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Products
{
    public class Milk : ProductBase
    {
        public Milk(string name = "Milk", decimal price = 1.15m)
            : base(name, price)
        {
        }
    }
}
