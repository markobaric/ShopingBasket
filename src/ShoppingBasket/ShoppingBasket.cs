using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingBasket.Offers;
using ShoppingBasket.Products;

namespace ShoppingBasket
{
    public class ShoppingBasket : IShoppingBasket
    {
        private IList<IShoppingBasketItem> _itemsInBasket = new List<IShoppingBasketItem>();
        private IList<IOffer> _offers;

        public ShoppingBasket(IList<IOffer> offers = null)
        {
            _offers = offers;
        }

        #region IShoppingBasket implementation

        public IList<IShoppingBasketItem> ItemsInBasket { get { return _itemsInBasket; } }

        public void AddItem(IShoppingBasketItem item)
        {
            _itemsInBasket.Add(item);
        }

        public void RemoveItem(IShoppingBasketItem item)
        {
            _itemsInBasket.Remove(item);
        }

        public decimal GetTotal()
        {
            if (_offers != null)
            {
                foreach (IOffer offer in _offers)
                {
                    offer.ProcessDiscounts(this);
                }
            }
            else
            {
                foreach (IShoppingBasketItem item in _itemsInBasket)
                {
                    item.UpdateItemPrice(1);
                }
            }

            return _itemsInBasket.Select(i => i.ItemPrice).Sum();
        }

        #endregion
    }
}
