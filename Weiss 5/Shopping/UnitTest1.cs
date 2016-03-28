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
            public double amount;
            public ShoppingList(string nameOfProduct, double amount)
            {
                this.nameOfProduct = nameOfProduct;
                this.amount = amount;
            }
        }
            public double CalculateTotalPrice(ShoppingList[] shoppingList)
            {
                double result = 0;
                for (int i = 0; i < shoppingList.Length; i++)
                {
                    result += shoppingList[i].amount;
                }
                return result;
            }
        
    }
}
