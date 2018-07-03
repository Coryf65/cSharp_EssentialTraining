using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cSharp_EssentialTraining;

namespace cSharp_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var testInstance = new Class1();          

            var testResult = testInstance.AddTwo(9, 5);

            Assert.AreEqual(14, testResult, "I Expect 9 + 5 to be 14");

        }
    }
}
