namespace Picker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UtilitiesTests
    {
        [TestMethod]
        public void GetVersionStringTest()
        {
            Assert.AreEqual("1", new Version(1, 0).GetVersionString());
            Assert.AreEqual("1", new Version(1, 0, 0, 0).GetVersionString());
            Assert.AreEqual("1.2", new Version(1, 2).GetVersionString());
            Assert.AreEqual("1.2", new Version(1, 2, 0, 0).GetVersionString());
            Assert.AreEqual("1.2.3", new Version(1, 2, 3).GetVersionString());
            Assert.AreEqual("1.2.3", new Version(1, 2, 3, 0).GetVersionString());
            Assert.AreEqual("1.0.3", new Version(1, 0, 3).GetVersionString());
            Assert.AreEqual("1.0.3", new Version(1, 0, 3, 0).GetVersionString());
            Assert.AreEqual("1.2.3.4", new Version(1, 2, 3, 4).GetVersionString());
            Assert.AreEqual("1.2.0.4", new Version(1, 2, 0, 4).GetVersionString());
        }
    }
}