using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace All.ChangeCase.Tests
{
    [TestClass]
    public class UpperCaseFirstTests
    {
        [TestMethod]
        public void UpperCaseFirstTest()
        {
            string input = null;
            Assert.AreEqual("", input.UpperCaseFirst());
            Assert.AreEqual("", "".UpperCaseFirst());
            Assert.AreEqual(" ", " ".UpperCaseFirst());
            Assert.AreEqual("Test", "test".UpperCaseFirst());
            Assert.AreEqual("TEST", "TEST".UpperCaseFirst());
            Assert.AreEqual("T", "t".UpperCaseFirst());
        }
    }
}
