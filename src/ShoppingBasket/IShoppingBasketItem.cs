using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingBasket.Offers;
using ShoppingBasket.Products;

namespace ShoppingBasket
{
    /// <summary>
    /// Commong interface for items in shopping basket
    /// </summary>
    public interface IShoppingBasketItem
    {
        decimal UpdateItemPrice(decimal discountMultiplicator, int dicountedQuantity = 0);

        IProduct Product { get; }
        int Quantity { get; } // I used 'int' for simplicity here, in a real application it would probably be 'double'
        decimal ItemPrice { get; }
    }
}
