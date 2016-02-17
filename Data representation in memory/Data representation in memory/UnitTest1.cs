using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Data_representation_in_memory
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConvertToBase2()
        {
          byte[] expected = { 1, 1,0,0,0,1};
          byte [] actual=GetTheTransformationOnTheBasis2(49);
          CollectionAssert.AreEquivalent(expected, actual);
        }
       byte[] GetTheTransformationOnTheBasis2(int number)
        {
            int size = (int)Math.Log(number, 2);
            byte[] bytes= new byte[size+1];
            while (number >= 1)
            {
                bytes [size]= (byte)(number % 2);
                number = number / 2;
                size--;

            }
            return  bytes;
        }
    }
}
