using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingBasket.Products;

namespace ShoppingBasket.Offers
{
    /// <summary>
    /// Offer:
    /// Buy 2 Butter and get a Bread at 50% off
    /// </summary>
    public class ButterOffer : IOffer
    {
        private const decimal DISCOUNT_MULTIPLICATOR = 0.5m;
        private const int MIN_NUMBER_OF_ITEMS_TO_EARN_DISCOUNT = 2;
        private const int MAX_NUMBER_OF_DISCOUNTS = 1;

        public void ProcessDiscounts(IShoppingBasket shoppingBasket)
        {
            int totalButterCount = shoppingBasket.ItemsInBasket.Where(i => i.Product is Butter).Select(i => i.Quantity).Sum();

            int numberOfFreeBreadsGiven = 0;

            foreach (IShoppingBasketItem item in shoppingBasket.ItemsInBasket)
            {
                if (item.Product is Bread &&
                    totalButterCount >= MIN_NUMBER_OF_ITEMS_TO_EARN_DISCOUNT &&
                    numberOfFreeBreadsGiven < MAX_NUMBER_OF_DISCOUNTS)
                {
                    item.UpdateItemPrice(DISCOUNT_MULTIPLICATOR, MAX_NUMBER_OF_DISCOUNTS - numberOfFreeBreadsGiven);
                    numberOfFreeBreadsGiven++;
                }
            }
        }
    }
}
