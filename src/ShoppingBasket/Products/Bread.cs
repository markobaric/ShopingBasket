using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Products
{
    public class Bread : ProductBase
    {
        public Bread(string name = "Bread", decimal price = 1.00m)
            : base(name, price)
        {
        }
    }
}
