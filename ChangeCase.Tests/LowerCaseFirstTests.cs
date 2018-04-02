using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace All.ChangeCase.Tests
{
    [TestClass]
    public class LowerCaseFirstTests
    {
        [TestMethod]
        public void LowerCaseTest()
        {
            string input = null;
            Assert.AreEqual("", input.LowerCaseFirst());
            Assert.AreEqual("", "".LowerCaseFirst());
            Assert.AreEqual(" ", " ".LowerCaseFirst());
            Assert.AreEqual("test", "test".LowerCaseFirst());
            Assert.AreEqual("tEST", "TEST".LowerCaseFirst());
            Assert.AreEqual("t", "T".LowerCaseFirst());
        }
    }
}
