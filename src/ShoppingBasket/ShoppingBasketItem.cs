using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingBasket.Offers;
using ShoppingBasket.Products;

namespace ShoppingBasket
{
    public class ShoppingBasketItem : IShoppingBasketItem
    {
        private IProduct _product;
        private int _quantity;
        private decimal _itemPrice;

        public ShoppingBasketItem(IProduct product, int quantity)
        {
            _product = product;
            _quantity = quantity;

            _itemPrice = _product.Price * Quantity;
        }

        #region IShoppingBasketItem implementation

        public IProduct Product { get { return _product;  } }
        public int Quantity { get { return _quantity; } } 
        public decimal ItemPrice { get { return _itemPrice; } }

        public decimal UpdateItemPrice(decimal discountMultiplicator, int dicountedQuantity)
        {
            int discountedQuantity = dicountedQuantity < Quantity ? dicountedQuantity : Quantity;

            _itemPrice = (Product.Price * discountedQuantity * discountMultiplicator) + (Product.Price * (Quantity - discountedQuantity));

            return _itemPrice;
        }

        #endregion
    }
}
