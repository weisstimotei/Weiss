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
            byte[] a = GetTheTransformationOnTheBasis2(6);
            byte[] b = GetTheTransformationOnTheBasis2(93);
            byte[] actual = OperationAND(a, b);
            byte[] expected = GetTheTransformationOnTheBasis2(6 & 93);
            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestForOperationOR()
        {
            byte[] a = GetTheTransformationOnTheBasis2(4);
            byte[] b = GetTheTransformationOnTheBasis2(9);
            byte[] expected = OperationOR(a, b);
            byte[] actual = GetTheTransformationOnTheBasis2(4 | 9);
            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestForOperationXOR()
        {
            byte[] a = GetTheTransformationOnTheBasis2(4);
            byte[] b = GetTheTransformationOnTheBasis2(9);
            byte[] expected = OperationXOR(a, b);
            byte[] actual = GetTheTransformationOnTheBasis2(4 ^ 9);
            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestForOperationRightHandShift()
        {
            byte[] a = GetTheTransformationOnTheBasis2(6);
            byte[] actual = OperationRightHandShift(a, 1);
            byte[] expected = GetTheTransformationOnTheBasis2(6 >> 1);
            CollectionAssert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestForOperationRightHandShift2()
        {
            byte[] a = GetTheTransformationOnTheBasis2(93);
            byte[] actual = OperationRightHandShift(a, 2);
            byte[] expected = GetTheTransformationOnTheBasis2(93 >> 2);
            CollectionAssert.AreEqual(expected, actual);
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
        byte[] OperationAND(byte[] first, byte[] second)
        {
            byte[] result = new byte[Math.Min(first.Length, second.Length)];
            for (int i = result.Length-1; i >=0; i--)
                result[i] = (byte)(GetByte(first, i) * GetByte(second, i));
            return result;
        }
        byte GetByte(byte[] a, int poz)
        {
            if(poz<a.Length)
                return a[a.Length-poz-1];
            return 0;
        }
        byte[] OperationOR(byte[] first, byte[] second)
        {
            byte[] result = new byte[Math.Max(first.Length, second.Length)];
            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (GetByte(first, i) ==1 || GetByte(second, i)==1)
                    result[i] = (byte)(1);
                else
                    result[i] = (byte)(0);
            }
            return result;
        }
        byte[] OperationXOR(byte[] first, byte[] second)
        {
            byte[] result = new byte[Math.Max(first.Length, second.Length)];
            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (GetByte(first, i) != GetByte(second, i))
                    result[i] = (byte)(1);
                else
                    result[i] = (byte)(0);
            }
            return result;
        }
        byte[] OperationRightHandShift(byte[] a, int position)
        {
            Array.Resize(ref a, a.Length - position);
            return a;
        }

    }
}
