using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ShoppingBasket;
using ShoppingBasket.Products;
using ShoppingBasket.Offers;

namespace ShoppingBasket.Tests
{
    [TestClass]
    public class ShoppingBasketTests
    {
        [TestMethod]
        public void OneBreadOneButterOneMilk()
        {
            // Arrange
            List<IOffer> offers = new List<IOffer>();
            offers.Add(new ButterOffer());
            offers.Add(new MilkOffer());

            IShoppingBasket basket = new ShoppingBasket(offers);
            basket.AddItem(new ShoppingBasketItem(new Bread(), 1));
            basket.AddItem(new ShoppingBasketItem(new Butter(), 1));
            basket.AddItem(new ShoppingBasketItem(new Milk(), 1));

            // Act
            decimal total = basket.GetTotal();

            // Assert
            Assert.AreEqual(2.95m, total);
        }

        [TestMethod]
        public void TwoButtersTwoBreads()
        {
            // Arrange
            List<IOffer> offers = new List<IOffer>();
            offers.Add(new ButterOffer());
            offers.Add(new MilkOffer());

            IShoppingBasket basket = new ShoppingBasket(offers);
            basket.AddItem(new ShoppingBasketItem(new Bread(), 2));
            basket.AddItem(new ShoppingBasketItem(new Butter(), 2));

            // Act
            decimal total = basket.GetTotal();

            // Assert
            Assert.AreEqual(3.10m, total);
        }

        [TestMethod]
        public void TwoButtersTwoBreads2()
        {
            // Arrange
            List<IOffer> offers = new List<IOffer>();
            offers.Add(new ButterOffer());
            offers.Add(new MilkOffer());

            IShoppingBasket basket = new ShoppingBasket(offers);
            basket.AddItem(new ShoppingBasketItem(new Bread(), 1));
            basket.AddItem(new ShoppingBasketItem(new Butter(), 1));
            basket.AddItem(new ShoppingBasketItem(new Bread(), 1));
            basket.AddItem(new ShoppingBasketItem(new Butter(), 1));

            // Act
            decimal total = basket.GetTotal();

            // Assert
            Assert.AreEqual(3.10m, total);
        }

        [TestMethod]
        public void FourMilks()
        {
            // Arrange
            List<IOffer> offers = new List<IOffer>();
            offers.Add(new ButterOffer());
            offers.Add(new MilkOffer());

            IShoppingBasket basket = new ShoppingBasket(offers);
            basket.AddItem(new ShoppingBasketItem(new Milk(), 4));

            // Act
            decimal total = basket.GetTotal();

            // Assert
            Assert.AreEqual(3.45m, total);
        }

        [TestMethod]
        public void FourMilks2()
        {
            // Arrange
            List<IOffer> offers = new List<IOffer>();
            offers.Add(new ButterOffer());
            offers.Add(new MilkOffer());

            IShoppingBasket basket = new ShoppingBasket(offers);
            basket.AddItem(new ShoppingBasketItem(new Milk(), 1));
            basket.AddItem(new ShoppingBasketItem(new Milk(), 1));
            basket.AddItem(new ShoppingBasketItem(new Milk(), 1));
            basket.AddItem(new ShoppingBasketItem(new Milk(), 1));

            // Act
            decimal total = basket.GetTotal();

            // Assert
            Assert.AreEqual(3.45m, total);
        }

        [TestMethod]
        public void FourMilks3()
        {
            // Arrange
            List<IOffer> offers = new List<IOffer>();
            offers.Add(new ButterOffer());
            offers.Add(new MilkOffer());

            IShoppingBasket basket = new ShoppingBasket(offers);
            basket.AddItem(new ShoppingBasketItem(new Milk(), 1));
            basket.AddItem(new ShoppingBasketItem(new Milk(), 3));

            // Act
            decimal total = basket.GetTotal();

            // Assert
            Assert.AreEqual(3.45m, total);
        }

        [TestMethod]
        public void TwoButtersOneBreadEightMilks()
        {
            // Arrange
            List<IOffer> offers = new List<IOffer>();
            offers.Add(new ButterOffer());
            offers.Add(new MilkOffer());

            IShoppingBasket basket = new ShoppingBasket(offers);
            basket.AddItem(new ShoppingBasketItem(new Butter(), 2));
            basket.AddItem(new ShoppingBasketItem(new Bread(), 1));
            basket.AddItem(new ShoppingBasketItem(new Milk(), 8));

            // Act
            decimal total = basket.GetTotal();

            // Assert
            Assert.AreEqual(9, total);
        }

        [TestMethod]
        public void TwoButtersOneBreadEightMilks2()
        {
            // Arrange
            List<IOffer> offers = new List<IOffer>();
            offers.Add(new ButterOffer());
            offers.Add(new MilkOffer());

            IShoppingBasket basket = new ShoppingBasket(offers);
            basket.AddItem(new ShoppingBasketItem(new Butter(), 1));
            basket.AddItem(new ShoppingBasketItem(new Butter(), 1));
            basket.AddItem(new ShoppingBasketItem(new Bread(), 1));
            basket.AddItem(new ShoppingBasketItem(new Milk(), 8));

            // Act
            decimal total = basket.GetTotal();

            // Assert
            Assert.AreEqual(9, total);
        }

        [TestMethod]
        public void TwoButtersOneBreadEightMilks3()
        {
            // Arrange
            List<IOffer> offers = new List<IOffer>();
            offers.Add(new ButterOffer());
            offers.Add(new MilkOffer());

            IShoppingBasket basket = new ShoppingBasket(offers);
            basket.AddItem(new ShoppingBasketItem(new Butter(), 1));
            basket.AddItem(new ShoppingBasketItem(new Butter(), 1));
            basket.AddItem(new ShoppingBasketItem(new Bread(), 1));
            basket.AddItem(new ShoppingBasketItem(new Milk(), 3));
            basket.AddItem(new ShoppingBasketItem(new Milk(), 5));

            // Act
            decimal total = basket.GetTotal();

            // Assert
            Assert.AreEqual(9, total);
        }
    }
}
