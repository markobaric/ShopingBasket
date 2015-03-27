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
    /// Defines the contract for shopping basket
    /// </summary>
    public interface IShoppingBasket
    {
        void AddItem(IShoppingBasketItem item);
        void RemoveItem(IShoppingBasketItem item);
        decimal GetTotal();

        IList<IShoppingBasketItem> ItemsInBasket { get; }
    }
}
