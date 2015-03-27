using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Products
{
    public class Butter : ProductBase
    {
        public Butter(string name = "Butter", decimal price = 0.80m)
            : base(name, price)
        {
        }
    }
}
