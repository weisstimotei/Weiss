using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Computer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdditionOperation()
        {
            int index = 0;
            Assert.AreEqual(7, GetCalculate("+ 2 5 ", ref index));
        }
        [TestMethod]
        public void TestSubtractionOperation()
        {
            int index = 0;
            Assert.AreEqual(3, GetCalculate("- 5 2 ", ref index));
        }
        [TestMethod]
        public void TestCalculateMoreAdditions()
        {
            int index = 0;
            Assert.AreEqual(10, GetCalculate("+ + 4 4 + 1 1", ref index));
        }
        [TestMethod]
        public void TestGetMultiply()
        {
            int index = 0;
            Assert.AreEqual(10, GetCalculate("* 2 5", ref index));
        }
        [TestMethod]
        public void TestGetDivision()
        {
            int index = 0;
            Assert.AreEqual(2.5, GetCalculate("/ 5 2", ref index));
        }
        [TestMethod]
        public void TestMultipleOperations()
        {
            int index = 0;
            Assert.AreEqual(5, GetCalculate("/ * 5 2 2", ref index));
        }
        double GetCalculate(string inputString, ref int index)
        {
            string[] elements = inputString.Split(' ');
            string firstElement = elements[index++];
            double number;
            if (Double.TryParse(firstElement, out number))
            {
                return number;
            }
            return GetOperation(inputString, ref index, firstElement);
        }

        private double GetOperation(string inputString, ref int index, string firstElement)
        {
            switch (firstElement)
            {
                case "+": return GetCalculate(inputString, ref index) + GetCalculate(inputString, ref index);
                case "*": return GetCalculate(inputString, ref index) * GetCalculate(inputString, ref index);
                case "/": return GetCalculate(inputString, ref index) / GetCalculate(inputString, ref index);
                default: return GetCalculate(inputString, ref index) - GetCalculate(inputString, ref index);
            }
        }
    }
}
