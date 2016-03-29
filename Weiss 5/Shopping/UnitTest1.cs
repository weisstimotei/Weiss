using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shopping
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateTotalPrice()
        {
            var shopping = new ShoppingList[] { new ShoppingList("bread", 7), new ShoppingList("milk", 3) };
            Assert.AreEqual(10, CalculateTotalPrice(shopping));
        }
        public struct ShoppingList
        {
            public string nameOfProduct;
            public double price;
            public ShoppingList(string nameOfProduct, double price)
            {
                this.nameOfProduct = nameOfProduct;
                this.price = price;
            }
        }
            public double CalculateTotalPrice(ShoppingList[] shoppingList)
            {
                double result = 0;
                for (int i = 0; i < shoppingList.Length; i++)
                {
                    result += shoppingList[i].price;
                }
                return result;
            }
        
    }
}
