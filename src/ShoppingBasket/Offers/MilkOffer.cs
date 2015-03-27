using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingBasket.Products;

namespace ShoppingBasket.Offers
{
    /// <summary>
    ///  Offer:
    ///  Buy 3 Milk and get the 4th milk for free
    /// </summary>
    public class MilkOffer : IOffer
    {
        private const decimal DISCOUNT_MULTIPLICATOR = 0;
        private const int MIN_NUMBER_OF_ITEMS_TO_EARN_DISCOUNT = 3;

        public void ProcessDiscounts(IShoppingBasket shoppingBasket)
        {
            int totalMilkCount = shoppingBasket.ItemsInBasket.Where(i => i.Product is Milk).Select(i => i.Quantity).Sum();

            int numberOfFreeMilksToGive = totalMilkCount / MIN_NUMBER_OF_ITEMS_TO_EARN_DISCOUNT;
            int numberOfFreeMilksGiven = 0;

            foreach (IShoppingBasketItem item in shoppingBasket.ItemsInBasket)
            {
                if (item.Product is Milk &&
                    totalMilkCount >= MIN_NUMBER_OF_ITEMS_TO_EARN_DISCOUNT &&
                    numberOfFreeMilksGiven < numberOfFreeMilksToGive)
                {
                    int numberOfFreeMilksToGiveInThisItem = item.Quantity / MIN_NUMBER_OF_ITEMS_TO_EARN_DISCOUNT;

                    // This handles special case when milks are added one by one in separate items
                    if (numberOfFreeMilksToGiveInThisItem == 0)
                        numberOfFreeMilksToGiveInThisItem = 1;

                    item.UpdateItemPrice(DISCOUNT_MULTIPLICATOR, numberOfFreeMilksToGiveInThisItem);
                    numberOfFreeMilksGiven += numberOfFreeMilksToGiveInThisItem;
                }
            }
        }
    }
}
