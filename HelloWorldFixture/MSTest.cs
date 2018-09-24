using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldFixture
{
    [TestClass]
    public class MSTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("This is an incredibly useless MS test, except to make sure a test can run.");
        }
    }
}
