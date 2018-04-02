using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace All.ChangeCase.Tests
{
    [TestClass]
    public class HeaderCaseTests
    {
        [TestMethod]
        public void SingleWordTest()
        {
            TestParamCase("test", "Test");
            TestParamCase("TEST", "Test");
        }

        [TestMethod]
        public void RegularSentenceTest()
        {
            TestParamCase("test string", "Test-String");
            TestParamCase("Test String", "Test-String");
        }

        [TestMethod]
        public void NonAlphanumericSeparatorsTest()
        {
            TestParamCase("dot.case", "Dot-Case");
            TestParamCase("path/case", "Path-Case");
        }

        [TestMethod]
        public void NumbersTest()
        {
            TestParamCase("testString1_2_3", "Test-String-1-2-3");
        }

        [TestMethod]
        public void NonLatinStrings()
        {
            TestParamCase("My Entrée", "My-Entrée");
        }

        [TestMethod]
        public void LocaleTest()
        {
            string actual = "A STRING".HeaderCase(CultureInfo.CreateSpecificCulture("tr"));
            Assert.AreEqual("A-Strıng", actual);
        }

        private void TestParamCase(string input, string expected)
        {
            string actual = input.HeaderCase();
            Assert.AreEqual(expected, actual);
        }
    }
}
