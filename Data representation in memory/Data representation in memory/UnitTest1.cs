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
        [TestMethod]
        public void TestForOperationAND()
        {
            byte[] value1 ={0,1,1,0};
            byte[] value2 = {1,0,1,1,1,0,1};
            byte[] actual = OperationAND(value1, value2);
            byte[] expected = {0,0,0,0,1,0,0};
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
        byte[] OperationAND(byte[] number1, byte[] number2)
        {
           byte[] result = new byte[Math.Max(number1.Length,number2.Length)];
            for (int i = result.Length-1; i >=0; i--)
                result[i] = (byte)(GetByte(number1,i) * GetByte(number2,i));
            return result;
        }
        byte GetByte(byte[] a, int poz)
        {
            if(poz<a.Length)
                return a[a.Length-poz-1];
            return 0;
        }
       
    }
}
