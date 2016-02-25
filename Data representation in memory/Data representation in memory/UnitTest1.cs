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
            byte[] expected = { 1, 1, 0, 0, 0, 1 };
            byte[] actual = GetTheTransformationOnTheBasis2(49);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestConvertToBase2ForZero()
        {
            byte[] expected = { 0 };
            byte[] actual = GetTheTransformationOnTheBasis2(0);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationNOT()
        {
            byte[] expected = { 0, 0, 1, 1, 1, 0 };
            byte[] actual = OperationNOT(GetTheTransformationOnTheBasis2(49));
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationAND()
        {
            byte[] a = GetTheTransformationOnTheBasis2(96);
            byte[] b = GetTheTransformationOnTheBasis2(3);
            byte[] actual = OperationAND(a, b);
            byte[] expected = GetTheTransformationOnTheBasis2(3 & 96);
            CollectionAssert.AreEqual(expected, actual);
        }
        public void TestForOperationAND2()
        {
            byte[] a = GetTheTransformationOnTheBasis2(9);
            byte[] b = GetTheTransformationOnTheBasis2(3);
            byte[] actual = OperationAND(a, b);
            byte[] expected = GetTheTransformationOnTheBasis2(3 & 9);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationOR()
        {
            byte[] a = GetTheTransformationOnTheBasis2(4);
            byte[] b = GetTheTransformationOnTheBasis2(9);
            byte[] expected = OperationOR(a, b);
            byte[] actual = GetTheTransformationOnTheBasis2(4 | 9);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationXOR()
        {
            byte[] a = GetTheTransformationOnTheBasis2(4);
            byte[] b = GetTheTransformationOnTheBasis2(9);
            byte[] expected = OperationXOR(a, b);
            byte[] actual = GetTheTransformationOnTheBasis2(4 ^ 9);
            CollectionAssert.AreEqual(expected, actual);
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
        [TestMethod]
        public void TestForOperationLeftHandShift()
        {
            byte[] a = GetTheTransformationOnTheBasis2(93);
            byte[] actual = OperationLeftHandShift(a, 1);
            byte[] expected = GetTheTransformationOnTheBasis2(93 << 1);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationLessThan1()
        {
            byte[] theLess = GetTheTransformationOnTheBasis2(3);
            byte[] theBigger = GetTheTransformationOnTheBasis2(9);
            Assert.AreEqual(true, OperationLessThan(theLess, theBigger));
        }
        [TestMethod]
        public void TestForOperationLessThan2()
        {
            byte[] theLess = GetTheTransformationOnTheBasis2(0);
            byte[] theBigger = GetTheTransformationOnTheBasis2(0);
            Assert.AreEqual(false, OperationLessThan(theLess, theBigger));
        }
        [TestMethod]
        public void TestForOperationLessThan3()
        {
            byte[] theLess = GetTheTransformationOnTheBasis2(14);
            byte[] theBigger = GetTheTransformationOnTheBasis2(9);
            Assert.AreEqual(false, OperationLessThan(theLess, theBigger));
        }
        byte[] GetTheTransformationOnTheBasis2(int number)
        {
            byte[] bits = new byte[1];
            int i = 1;
            while (number != 0)
            {
                Array.Resize(ref bits, i);
                bits[i - 1] = (byte)(number % 2);
                i++;
                number = number / 2;
            }
            return GetMirroringNumber(bits);

        }
        byte[] OperationNOT(byte[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == 1)
                    number[i] = 0;
                else
                    number[i] = 1;
            }
            return number;
        }
        byte[] OperationAND(byte[] first, byte[] second)
        {
            int k = 0;
            byte[] zero = new byte[1];
            byte[] result = new byte[Math.Max(first.Length, second.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                if (GetByte(first, i) == 1 && GetByte(second, i) == 1)
                    result[i] = (byte)1;
                else
                {
                    result[i] = (byte)0;
                    k++;
                }
            }
            if (k == Math.Max(first.Length, second.Length))
                return zero;
            else
                return RemoveLeadingZeros(GetMirroringNumber(result));
        }
        byte[] RemoveLeadingZeros(byte[] a)
        {
            int k = 0;
            int position = 0;
            for (int i = 0; i < a.Length && a[i] == 0; i++)
            {
                k++;
            }
            byte[] result = new byte[a.Length - k];
            for (int j = k + 1; j <= a.Length; j++)
            {
                result[position] = a[j - 1];
                position++;
            }
            return result;
        }

        private static byte[] GetMirroringNumber(byte[] result)
        {
            byte[] res = new byte[result.Length];
            for (int j = 0; j < result.Length; j++)
            {
                res[j] = result[result.Length - j - 1];
            }
            return res;
        }
        byte GetByte(byte[] a, int poz)
        {
            if (poz < a.Length)
                return a[a.Length - poz - 1];
            return 0;
        }
        byte[] OperationOR(byte[] first, byte[] second)
        {

            byte[] result = new byte[Math.Max(first.Length, second.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                if (GetByte(first, i) == 1 || GetByte(second, i) == 1)
                    result[i] = (byte)(1);
                else
                    result[i] = (byte)(0);
            }
            return GetMirroringNumber(result);
        }
        byte[] OperationXOR(byte[] first, byte[] second)
        {

            byte[] result = new byte[Math.Max(first.Length, second.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                if (GetByte(first, i) != GetByte(second, i))
                    result[i] = (byte)(1);
                else
                    result[i] = (byte)(0);
            }
            return GetMirroringNumber(result);
        }
        byte[] OperationRightHandShift(byte[] a, int position)
        {
            Array.Resize(ref a, a.Length - position);
            return a;
        }
        byte[] OperationLeftHandShift(byte[] a, int position)
        {
            Array.Resize(ref a, a.Length + position);
            return a;
        }
        bool OperationLessThan(byte[] theLess, byte[] theBigger)
        {
            int i = theLess.Length - 1;
            if (theLess.Length < theBigger.Length)
                return true;
            while (i >= 0)
            {
                if (GetByte(theLess, i) == GetByte(theBigger, i))
                i--;
                else 
                    if (GetByte(theLess, i) > GetByte(theBigger, i))
                        return false;
                    else
                        return true;
            }
            return false;


        }
    }
}

