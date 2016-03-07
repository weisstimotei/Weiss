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
            byte[] actual= Addition(a,b);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationAddition2()
        {
            byte[] a = GetTheTransformationOnBase(0, 2);
            byte[] b = GetTheTransformationOnBase(0, 2);
            byte[] expected = GetTheTransformationOnBase(0, 2);
            byte[] actual = Addition(a, b);
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
            byte[] actual = Multiplication(theSmallNumber, theBigNumber);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForOperationMultiplication2()
        {
            byte[] theSmallNumber = GetTheTransformationOnBase(0, 2);
            byte[] theBigNumber = GetTheTransformationOnBase(0, 2);
            byte[] expected = GetTheTransformationOnBase(0, 2);
            byte[] actual = Multiplication(theSmallNumber, theBigNumber);
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
        public void TestForOperationEqual()
        {
            byte[] first = GetTheTransformationOnBase(7, 2);
            byte[] second = GetTheTransformationOnBase(7, 2);
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
        public void TestForDivision()
        {
            byte[] theBigNumber = GetTheTransformationOnBase(22, 2);
            byte[] theSmallNumber = GetTheTransformationOnBase(11, 2);
            byte[] expected = GetTheTransformationOnBase(2, 2);
            byte[] actual = Division(theBigNumber, theSmallNumber);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForDivision2()
        {
            byte[] theBigNumber = GetTheTransformationOnBase(22, 2);
            byte[] theSmallNumber = GetTheTransformationOnBase(1, 2);
            CollectionAssert.AreEqual(GetTheTransformationOnBase(22, 2), Division(theBigNumber, theSmallNumber));
        }
        [TestMethod]
        public void TestForDivision3()
        {
            byte[] theBigNumber = GetTheTransformationOnBase(22, 2);
            byte[] theSmallNumber = GetTheTransformationOnBase(22, 2);
            CollectionAssert.AreEqual(GetTheTransformationOnBase(1, 2), Division(theBigNumber, theSmallNumber));
        }
        [TestMethod]
        public void TestForDivision4()
        {
            byte[] theBigNumber = GetTheTransformationOnBase(0, 2);
            byte[] theSmallNumber = GetTheTransformationOnBase(22, 2);
            CollectionAssert.AreEqual(GetTheTransformationOnBase(0, 2), Division(theBigNumber, theSmallNumber));
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
                GettingCases(first, second, operation, result, i);
            }
             return GetMirroringNumber(result);
         }

         private void GettingCases(byte[] first, byte[] second, string operation, byte[] result, int i)
         {
             switch (operation)
             {
                 case "AND":
                     result[i] = (GetByte(first, i) == 1 && GetByte(second, i) == 1) ? (byte)1 : (byte)0;
                     break;
                 case "OR":
                     result[i] = (GetByte(first, i) == 1 || GetByte(second, i) == 1) ? (byte)(1) : (byte)(0);
                     break;
                 case "XOR":
                     result[i] = (GetByte(first, i) != GetByte(second, i)) ? (byte)(1) : (byte)(0);
                     break;
             }
         }
         byte[] Addition(byte[] first, byte [] second)
         {
             byte[] zero = new byte[1];
             byte[] result = new byte[Math.Max(first.Length, second.Length)+1];
             int remainder = 0;
             for (int i = 0; i < result.Length; i++)
             {
                 int sum = GetByte(first, i) + GetByte(second, i) + remainder;
                 result[i] = (byte)(sum % 2);
                 remainder = sum / 2;
             }
             if (first[0] == 0 && second[0] == 0)
                 return zero;
             return FormatResult(GetMirroringNumber(result));
         }
         byte[] FormatResult(byte[] result)
         {
             int position = 0;
             for (int j = 0; j < result.Length; j++)
             {
                 if (result[j] == 0)
                     position++;
                 else break;
             }
             byte[] formatedResult = new byte[result.Length - position];
             for (int j = 0; j < formatedResult.Length; j++)
                 formatedResult[j] = result[j + position];
             return formatedResult;
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
             return FormatResult(GetMirroringNumber(result));
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
         byte[] Multiplication(byte[] first, byte[] second)
         {
             byte[] result = { 0 };
             for (byte[] i = new byte[] {0}; OperationLessThan(i,first); i=Addition(i,new byte[] {1}))
             {
                 result = Addition(result, second);
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
         byte[] Division(byte[] first, byte[] second)
         {
             byte[] result = { 1 };
             for (byte[] i = first; OperationLessThan(second, i); i = Subtraction(i, second))
             {
                 result = Addition(result, new byte[] { 1 });
             }
             if (OperationLessThan(first, new byte[] { 1 }))
                 return first;
             return result;
         }
    }
}

