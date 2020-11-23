﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    [TestCategory("LoginFeature")]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Positive")]
        [Description("these are demo unit tests")]
        public void TestMethod1()
        {
            var a = 1;
            var b = 2;
            Assert.AreEqual(3, a + b);
  
        }
        [TestMethod]
        public void TestMethod2()
        {
            var a = 1;
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))] // unit testing
        public void TestMethod3()
        {
            var a = 5;
            Assert.AreNotEqual(5, 5);
        }


    }
}
