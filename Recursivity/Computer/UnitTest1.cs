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
            Assert.AreEqual(7, GetCalculate("+ 2 5 "));
        }
        [TestMethod]
        public void TestSubtractionOperation()
        {
            Assert.AreEqual(3, GetCalculate("- 5 2 "));
        }
        double GetCalculate(string inputString)
        {
            string[] elements = inputString.Split(' ');
            string firstElement = elements[0];
            double number;
            if (Double.TryParse(elements[0], out number))
            {
                return number;
            }
            switch (firstElement)
            {
                case "+": return GetCalculate(elements[1]) + GetCalculate(elements[2]);
                default: return GetCalculate(elements[1]) - GetCalculate(elements[2]);
            }
        }
    }
}
