using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace All.ChangeCase.Tests
{
    [TestClass]
    public class SwapCaseTests
    {
        [TestMethod]
        public void SwapCaseInStringsTest()
        {
            string input = null;
            Assert.AreEqual(input.SwapCase(),"");
            Assert.AreEqual("test".SwapCase(), "TEST");
            Assert.AreEqual("TEST".SwapCase(), "test");
            Assert.AreEqual("PascalCase".SwapCase(), "pASCALcASE");
            Assert.AreEqual("Iñtërnâtiônàlizætiøn".SwapCase(), "iÑTËRNÂTIÔNÀLIZÆTIØN");
        }

        [TestMethod]
        public void LocaleSupportTest()
        {
            Assert.AreEqual("mY sTRİNG", "My String".SwapCase(CultureInfo.CreateSpecificCulture("tr")));
        }
    }
}
