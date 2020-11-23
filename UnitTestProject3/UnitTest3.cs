using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    [TestCategory("Part 3")]
    public class UnitTest3
    {   private int a;
        public TestContext Test3Context { get; set; }
        private static TestContext _testContext;
        [TestInitialize]
        public void RunBeforeEveryTest() 
        {
            a = 1;
        }
        [TestCleanup]
        public void RunAfterEveryMethod() 
        {
            Trace.Write("RunAfterEveryTestMethod will execute after every single test method in a class");
        }
        [TestMethod]
        public void TestMethod1()
        {
           
            var b = 2;
            Assert.AreEqual(3, a + b);
        }
        [TestMethod]
        public void TestMethod2() 
        {
            
            Assert.IsTrue(a == 1);
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3() 
        {
            var a = 1;
            Assert.AreNotEqual(1, a);
        }
    }
}
