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
        [TestMethod]
        public void TestForCheapestObject()
        {
            var shopping = new ShoppingList[] { new ShoppingList("milk", 8), new ShoppingList("bread", 7)};
            Assert.AreEqual("bread", GetTheCheapestPrice(shopping));
        }
        [TestMethod]
        public void TestForAveragePrice()
        {
            var shopping = new ShoppingList[] { new ShoppingList("milk", 10), new ShoppingList("bread", 3) };
            Assert.AreEqual(6.5, GetAverageShopping(shopping));
        }
        [TestMethod]
        public void TestForCountObjects()
        {
            var shopping = new ShoppingList[] { new ShoppingList("milk", 7), new ShoppingList("bread", 3) };
            Assert.AreEqual(1, CountObjects(RemoveTheMostExpensive(shopping)));
        }
        [TestMethod]
        public void TestForRemoveTheMostExpensive()
        {
            var shopping = new ShoppingList[] { new ShoppingList("oil", 4), new ShoppingList("bread", 10) };
            CollectionAssert.AreEqual(new ShoppingList[] {new ShoppingList("oil",4) }, RemoveTheMostExpensive(shopping));

        }
        [TestMethod]
        public void TestForAddObject()
        {
            var actualShopping = new ShoppingList[] { new ShoppingList("oil", 5), new ShoppingList("bread", 15) };
            var newObject = new ShoppingList("milk", 4);
            var newListOfObjects = new ShoppingList[] { new ShoppingList("oil", 5), new ShoppingList("bread", 15), new ShoppingList("milk", 4) };
            CollectionAssert.AreEqual(newListOfObjects, AddObject(actualShopping, newObject));
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
        public string GetTheCheapestPrice(ShoppingList[] shoppingObject)
        {
            ShoppingList firstObject = shoppingObject[0];
            double result = 0;
            string TheProduct = String.Empty;
            for (int i = 0; i < shoppingObject.Length; i++)
            {
                if (firstObject.price < shoppingObject[i].price)
                    result = result;
                else
                {
                    result = shoppingObject[i].price;
                    TheProduct = shoppingObject[i].nameOfProduct;
                }
            }
            return TheProduct;
        }
        public double GetAverageShopping(ShoppingList[] shoppingObject)
        {
            return CalculateTotalPrice(shoppingObject) / shoppingObject.Length;
        }
        public int CountObjects(ShoppingList[] shoppingObjects)
        {
            return shoppingObjects.Length;
        }
        public ShoppingList[] RemoveTheMostExpensive(ShoppingList[] shoppingObjects)
        {
            ShoppingList firstObject = shoppingObjects[0];
            ShoppingList result = shoppingObjects[0];
            for (int i = 0; i < shoppingObjects.Length; i++)
            {
                result = (firstObject.price > shoppingObjects[i].price) ? result : shoppingObjects[i];
            }
            Array.Resize(ref shoppingObjects, shoppingObjects.Length - 1);
            return shoppingObjects;
        }
        public ShoppingList[] AddObject(ShoppingList[] shoppingObjects, ShoppingList newObject)
        {
            Array.Resize(ref shoppingObjects, shoppingObjects.Length + 1);
            shoppingObjects[shoppingObjects.Length - 1] = newObject;
            return shoppingObjects;
        }
    }
}
