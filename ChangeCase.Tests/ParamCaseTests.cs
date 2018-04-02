using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace All.ChangeCase.Tests
{
    [TestClass]
    public class ParamCaseTests
    {
        [TestMethod]
        public void SingleWordTest()
        {
            TestParamCase("test","test");
            TestParamCase("TEST","test");
        }

        [TestMethod]
        public void RegularSentenceTest()
        {
            TestParamCase("test string", "test-string");
            TestParamCase("Test String", "test-string");
        }

        [TestMethod]
        public void NonAlphanumericSeparatorsTest()
        {
            TestParamCase("dot.case", "dot-case");
            TestParamCase("path/case", "path-case");
        }

        [TestMethod]
        public void NumbersTest()
        {
            TestParamCase("testString1_2_3", "test-string-1-2-3");
        }

        [TestMethod]
        public void NonLatinStrings()
        {
            TestParamCase("My Entrée", "my-entrée");
        }

        [TestMethod]
        public void LocaleTest()
        {
            string actual = "A STRING".ParamCase(CultureInfo.CreateSpecificCulture("tr"));
            Assert.AreEqual("a-strıng", actual);
        }

        private void TestParamCase(string input, string expected)
        {
            string actual = input.ParamCase();
            Assert.AreEqual(expected, actual);
        }
    }
}
