﻿using System;
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
            byte[] actual = GetTheTransformationOnBase(49, 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestConvertToBase8()
        {
            byte[] expected = { 4, 6, 7, 2 };
            byte[] actual = GetTheTransformationOnBase(2490, 8);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestConvertToBase2ForZero()
        {
            byte[] expected = { 0 };
            byte[] actual = GetTheTransformationOnBase(0, 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationNOT()
        {
            byte[] expected = { 0, 0, 1, 1, 1, 0 };
            byte[] actual = OperationNOT(GetTheTransformationOnBase(49, 2));
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationAND()
        {
            byte[] a = GetTheTransformationOnBase(96, 2);
            byte[] b = GetTheTransformationOnBase(3, 2);
            byte[] actual = OperationAND(a, b);
            byte[] expected = GetTheTransformationOnBase((3 & 96), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        public void TestForOperationAND2()
        {
            byte[] a = GetTheTransformationOnBase(9, 2);
            byte[] b = GetTheTransformationOnBase(3, 2);
            byte[] actual = OperationAND(a, b);
            byte[] expected = GetTheTransformationOnBase((3 & 9), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationOR()
        {
            byte[] a = GetTheTransformationOnBase(4, 2);
            byte[] b = GetTheTransformationOnBase(9, 2);
            byte[] expected = OperationOR(a, b);
            byte[] actual = GetTheTransformationOnBase((4 | 9), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationXOR()
        {
            byte[] a = GetTheTransformationOnBase(4, 2);
            byte[] b = GetTheTransformationOnBase(9, 2);
            byte[] expected = OperationXOR(a, b);
            byte[] actual = GetTheTransformationOnBase((4 ^ 9), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationRightHandShift()
        {
            byte[] a = GetTheTransformationOnBase(6, 2);
            byte[] actual = OperationRightHandShift(a, 1);
            byte[] expected = GetTheTransformationOnBase((6 >> 1), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationRightHandShift2()
        {
            byte[] a = GetTheTransformationOnBase(93, 2);
            byte[] actual = OperationRightHandShift(a, 2);
            byte[] expected = GetTheTransformationOnBase((93 >> 2), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationLeftHandShift()
        {
            byte[] a = GetTheTransformationOnBase(93, 2);
            byte[] actual = OperationLeftHandShift(a, 1);
            byte[] expected = GetTheTransformationOnBase((93 << 1), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationLessThan1()
        {
            byte[] theLess = GetTheTransformationOnBase(3, 2);
            byte[] theBigger = GetTheTransformationOnBase(9, 2);
            Assert.AreEqual(true, OperationLessThan(theLess, theBigger));
        }
        [TestMethod]
       public void TestForOperationLessThan2()
        {
            byte[] theLess = GetTheTransformationOnBase(0, 2);
            byte[] theBigger = GetTheTransformationOnBase(0, 2);
            Assert.AreEqual(false, OperationLessThan(theLess, theBigger));
        }
        [TestMethod]
        public void TestForOperationLessThan3()
        {
            byte[] theLess = GetTheTransformationOnBase(14, 2);
            byte[] theBigger = GetTheTransformationOnBase(9, 2);
            Assert.AreEqual(false, OperationLessThan(theLess, theBigger));
        }
        public void TestForOperationLessThan4()
        {
            byte[] theLess = GetTheTransformationOnBase(14, 255);
            byte[] theBigger = GetTheTransformationOnBase(9, 255);
            Assert.AreEqual(false, OperationLessThan(theLess, theBigger));
        }
        [TestMethod]
        public void TestForOperationAddition()
        {
            byte[] a = GetTheTransformationOnBase(70, 2);
            byte[] b = GetTheTransformationOnBase(2, 2);
            byte[] expected = GetTheTransformationOnBase(72, 2);
            byte[] actual= Addition(a,b,2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationAddition2()
        {
            byte[] a = GetTheTransformationOnBase(0, 2);
            byte[] b = GetTheTransformationOnBase(0, 2);
            byte[] expected = GetTheTransformationOnBase(0, 2);
            byte[] actual = Addition(a, b,2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationAddition3()
        {
            byte[] a = GetTheTransformationOnBase(7, 200);
            byte[] b = GetTheTransformationOnBase(4, 200);
            byte[] expected = GetTheTransformationOnBase(11, 200);
            byte[] actual = Addition(a, b, 200);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationSubtraction()
        {
            byte[] a = GetTheTransformationOnBase(5, 2);
            byte[] b = GetTheTransformationOnBase(2, 2);
            byte[] expected = GetTheTransformationOnBase(3, 2);
            byte[] actual = Subtraction(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationSubtraction2()
        {
            byte[] a = GetTheTransformationOnBase(0, 2);
            byte[] b = GetTheTransformationOnBase(0, 2);
            byte[] expected = GetTheTransformationOnBase(0, 2);
            byte[] actual = Subtraction(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationSubtraction3()
        {
            byte[] a = GetTheTransformationOnBase(20, 200);
            byte[] b = GetTheTransformationOnBase(2, 200);
            byte[] expected = GetTheTransformationOnBase(18, 200);
            byte[] actual = Subtraction(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationMultiplication()
        {
            byte[] theSmallNumber = GetTheTransformationOnBase(7, 2);
            byte[] theBigNumber = GetTheTransformationOnBase(9, 2);
            byte[] expected = GetTheTransformationOnBase(63, 2);
            byte[] actual = Multiplication(theSmallNumber, theBigNumber,2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationMultiplication2()
        {
            byte[] theSmallNumber = GetTheTransformationOnBase(0, 2);
            byte[] theBigNumber = GetTheTransformationOnBase(0, 2);
            byte[] expected = GetTheTransformationOnBase(0, 2);
            byte[] actual = Multiplication(theSmallNumber, theBigNumber,2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationMultiplication3()
        {
            byte[] theSmallNumber = GetTheTransformationOnBase(10, 200);
            byte[] theBigNumber = GetTheTransformationOnBase(4, 200);
            byte[] expected = GetTheTransformationOnBase(40, 200);
            byte[] actual = Multiplication(theSmallNumber, theBigNumber, 200);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationGraterThan()
        {
            byte[] theBigger = GetTheTransformationOnBase(14, 2);
            byte[] theLess = GetTheTransformationOnBase(5, 2);
            Assert.AreEqual(true, OperationGraterThan(theBigger, theLess));
        }
        [TestMethod]
        public void TestForOperationGraterThan2()
        {
            byte[] theBigger = GetTheTransformationOnBase(11, 200);
            byte[] theLess = GetTheTransformationOnBase(5, 200);
            Assert.AreEqual(true, OperationGraterThan(theBigger, theLess));
        }
        [TestMethod]
        public void TestForOperationEqual()
        {
            byte[] first = GetTheTransformationOnBase(7, 2);
            byte[] second = GetTheTransformationOnBase(7, 2);
            Assert.AreEqual(true, OperationEqual(first, second));
        }
        [TestMethod]
        public void TestForOperationEqual2()
        {
            byte[] first = GetTheTransformationOnBase(14, 200);
            byte[] second = GetTheTransformationOnBase(14, 200);
            Assert.AreEqual(true, OperationEqual(first, second));
        }
        [TestMethod]
        public void TestForOperationNotEqual()
        {
            byte[] first = GetTheTransformationOnBase(5, 2);
            byte[] second = GetTheTransformationOnBase(6, 2);
            Assert.AreEqual(true, OperationNotEqual(first, second));
        }
        [TestMethod]
        public void TestForOperationNotEqual2()
        {
            byte[] first = GetTheTransformationOnBase(4, 200);
            byte[] second = GetTheTransformationOnBase(6, 200);
            Assert.AreEqual(true, OperationNotEqual(first, second));
        }
        [TestMethod]
        public void TestForDivision()
        {
            byte[] theBigNumber = GetTheTransformationOnBase(22, 2);
            byte[] theSmallNumber = GetTheTransformationOnBase(11, 2);
            byte[] expected = GetTheTransformationOnBase(2, 2);
            byte[] actual = Division(theBigNumber, theSmallNumber,2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForDivision2()
        {
            byte[] theBigNumber = GetTheTransformationOnBase(22, 2);
            byte[] theSmallNumber = GetTheTransformationOnBase(1, 2);
            CollectionAssert.AreEqual(GetTheTransformationOnBase(22, 2), Division(theBigNumber, theSmallNumber,2));
        }
        [TestMethod]
        public void TestForDivision3()
        {
            byte[] theBigNumber = GetTheTransformationOnBase(22, 2);
            byte[] theSmallNumber = GetTheTransformationOnBase(22, 2);
            CollectionAssert.AreEqual(GetTheTransformationOnBase(1, 2), Division(theBigNumber, theSmallNumber,2));
        }
        [TestMethod]
        public void TestForDivision4()
        {
            byte[] theBigNumber = GetTheTransformationOnBase(0, 2);
            byte[] theSmallNumber = GetTheTransformationOnBase(22, 2);
            CollectionAssert.AreEqual(GetTheTransformationOnBase(0, 2), Division(theBigNumber, theSmallNumber,2));
        }
        [TestMethod]
        public void TestForDivision5()
        {
            byte[] theBigNumber = GetTheTransformationOnBase(44, 200);
            byte[] theSmallNumber = GetTheTransformationOnBase(22, 200);
            CollectionAssert.AreEqual(GetTheTransformationOnBase(2, 200), Division(theBigNumber, theSmallNumber, 200));
        }
        [TestMethod]
        public void TestForFactorial()
        {
            byte[] a = GetTheTransformationOnBase(4, 2);
            byte[] expected = GetTheTransformationOnBase(24, 2);
            byte[] actual = GetFactorial(a, 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForFactorial2()
        {
            byte[] a = GetTheTransformationOnBase(49, 2);
            byte[] b = GetTheTransformationOnBase(48, 2);
            byte[] expected = GetTheTransformationOnBase(49, 2);
            byte[] actual = Division(GetFactorial(a, 2), GetFactorial(b, 2),2);
            CollectionAssert.AreEqual(expected, actual);
        }
        byte[] GetTheTransformationOnBase(int number, int b)
        {
            byte[] bits = new byte[1];
            int i = 1;
            while (number != 0)
            {
                Array.Resize(ref bits, i);
                bits[i - 1] = (byte)(number % b);
                i++;
                number = number / b;
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
            return ExecuteLogicOperation(first, second, "AND");
        }
        

        private static byte[] GetMirroringNumber(byte[] result)
        {
            int k=0;
            byte[] zero = new byte[1];
            byte[] res = new byte[result.Length];
            for (int j = 0; j < result.Length; j++)
            {
                res[j] = result[result.Length - j - 1];
                if (res[j] == 0)
                  k++;
            }
            if (k == result.Length)
                return zero;
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
            return ExecuteLogicOperation(first, second, "OR");
        }
        byte[] OperationXOR(byte[] first, byte[] second)
        {
            return ExecuteLogicOperation(first, second, "XOR");
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
                if (GetByte(theLess, i) != GetByte(theBigger, i))
                {
                    if (GetByte(theLess, i) > GetByte(theBigger, i))
                        return false;
                    return true;
                }
                i--;
            }
            return false;
        }
         byte[] ExecuteLogicOperation(byte[] first, byte[] second, string operation)
        {
            byte[] result = new byte[Math.Max(first.Length, second.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = GettingCases(GetByte(first, i), GetByte(second, i), operation);
            }
             return GetMirroringNumber(result);
         }

         private byte GettingCases(byte first, byte second, string operation)
         {
             switch (operation)
             {
                 case "AND":
                     return  GetCaseAND(first, second);
                 case "OR":
                     return  GetCaseOR(first, second);
                 case "XOR":
                     return GetCaseXOR(first, second);
             }
             return first;
         }

         private static byte GetCaseXOR(byte first, byte second)
         {
             if (first != second)
                 return (byte)1;
             return (byte)0;
         }

         private static byte GetCaseOR(byte first, byte second)
         {
             if (first == 1 || second == 1)
                 return (byte)1;
             return (byte)0;
         }

         private static byte GetCaseAND(byte first, byte second)
         {
             if (first == 1 && second == 1)
                 return (byte)1;
             return (byte)0;
         }
         byte[] Addition(byte[] first, byte [] second,int b)
         {
             byte[] zero = new byte[1];
             byte[] result = new byte[Math.Max(first.Length, second.Length)+1];
             int remainder = 0;
             for (int i = 0; i < result.Length; i++)
             {
                 int sum = GetByte(first, i) + GetByte(second, i) + remainder;
                 result[i] = (byte)(sum % b);
                 remainder = sum / b;
             }
             if (first[0] == 0 && second[0] == 0)
                 return zero;
             return GetMirroringNumber(FormatResult(result));
         }
         byte[] FormatResult(byte[] result)
         {
             for (int j = result.Length-1; j>=0; j--)
             {
                 if (result[j] == 0)
                     Array.Resize(ref result, j);
                 else
                     break;
             }
             return result;
         }
         byte[] Subtraction(byte[] first, byte[] second)
         {
             byte[] zero = new byte[1];
             byte[] result = new byte[Math.Max(first.Length, second.Length)];
             int carry = 0;
             for (int i = 0; i < result.Length; i++)
             {
                var diff = GetByte(first, i) - GetByte(second, i) - carry;
                GetTheIfForSubtraction(ref carry, ref diff);
                 result[i] = (byte)diff;
             }
             if (first[0] == 0 && second[0] == 0)
                 return zero;
             return GetMirroringNumber(FormatResult(result));
         }

         private static void GetTheIfForSubtraction(ref int carry, ref int diff)
         {
             if (diff < 0)
             {
                 diff += 2;
                 carry = 1;
             }
             else
             {
                 carry = 0;
             }
         }
         byte[] Multiplication(byte[] first, byte[] second,int b)
         {
             byte[] result = { 0 };
             for (byte[] i = new byte[] {0}; OperationLessThan(i,first); i=Addition(i,new byte[] {1},b))
             {
                 result = Addition(result, second,b);
             }
             return result;
         }
         bool OperationGraterThan(byte[] first, byte[] second)
         {
              return OperationLessThan(second, first);
         }
         bool OperationEqual(byte[] first, byte[] second)
         {
             return (!OperationLessThan(first, second)  && !OperationLessThan(second, first));
         }
         bool OperationNotEqual(byte[] first, byte[] second)
         {
             return (!OperationLessThan(first, second)  || !OperationLessThan(second, first));
         }
         byte[] Division(byte[] first, byte[] second,int b)
         {
             byte[] result = { 1 };
             for (byte[] i = first; OperationLessThan(second, i); i = Subtraction(i, second))
             {
                 result = Addition(result, new byte[] { 1 },b);
             }
             if (OperationLessThan(first, new byte[] { 1 }))
                 return first;
             return result;
         }
        byte[]  GetFactorial(byte[] number,int b)
        {
            byte[] one = new byte[] { 1 };
            byte[] product = { 1 };
            for (byte[] i = one; OperationLessThan(Subtraction(i,one), number); i = Addition(i, one, b))
            {
                product = Multiplication(product,i,b);
            }
            return product;
        }
    }
}

