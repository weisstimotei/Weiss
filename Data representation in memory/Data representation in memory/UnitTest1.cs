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
        [TestMethod]
        public void TestForOperationNOT()
        {
            byte[] expected = {0,0,1,1,1,0};
            byte[] actual = OperationNOT(GetTheTransformationOnTheBasis2(49));
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
       byte[] OperationNOT(byte[] number)
       {
           for (int i = 0; i < number.Length; i++)
           {
               if (number[i]==1)
                   number[i] = 0;
               else
                   number[i] = 1;
           }
           return number;
       }
    }
}
