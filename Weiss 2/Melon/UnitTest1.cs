﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Melon
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IfTheAnswerIsTrue()
        {
            Assert.AreEqual("DA",GetTheAnswer(8));
        }
        [TestMethod]
        public void IfTheAnswerIsFalse()
        {
            Assert.AreEqual("NU", GetTheAnswer(9));
        }
        [TestMethod]
        public void IfTheAnswerIsFalseFor2()
        {
            Assert.AreEqual("NU", GetTheAnswer(2));
        }
        string GetTheAnswer(int kg)
        {
            if (kg >2 && kg % 2==0)
               return "DA";
            else
               return "NU";
        }
    }
}
