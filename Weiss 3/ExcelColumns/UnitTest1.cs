﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumns
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForNumber1()
        {
            Assert.AreEqual("A", GetTheCodification(1));
        }
        [TestMethod]
        public void TestForNumber26()
        {
            Assert.AreEqual("Z", GetTheCodification(26));
        }
        [TestMethod]
        public void TestForNumber52()
        {
            Assert.AreEqual("AZ", GetTheCodification(52));
        }
        [TestMethod]
        public void TestForNumber702()
        {
            Assert.AreEqual("ZZ", GetTheCodification(702));
        }
        string GetTheCodification(int column)
    {
        string[] key = {"","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        if (GetTheParticularisation(column))
            return ReturnForParticularisation(column, key);
      else
            return GetTheReturnForElse(column, key);
     
    }

        private static string GetTheReturnForElse(int column, string[] key)
        {
            return key[column / 27] + key[column - 26 * (column / 27)];
        }

        private static string ReturnForParticularisation(int column, string[] key)
        {
            return key[column / 26] + key[1];
        }

        private static bool GetTheParticularisation(int column)
        {
            return ((column - 1) % 26 == 0);
        }
    }
}
