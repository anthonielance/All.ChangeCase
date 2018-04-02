using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace All.ChangeCase.Tests
{
    [TestClass]
    public class CamelCaseTests
    {
        [TestMethod]
        public void SingleWordTest()
        {
            TestCamelCase("test", "test");
            TestCamelCase("TEST", "test");
        }


        [TestMethod]
        public void RegularSentenceCasedStringsTest()
        {
            TestCamelCase("test string", "testString");
            TestCamelCase("Test String", "testString");
        }

        [TestMethod]
        public void NonAlphanumericSeparatorsTest()
        {
            TestCamelCase("dot.case", "dotCase");
            TestCamelCase("path/case", "pathCase");
        }

        [TestMethod]
        public void UnderscorePeriodsInsideNumbersTest()
        {
            TestCamelCase("version 1.2.10","version1_2_10");
            TestCamelCase("version 1.21.0","version1_21_0");
        }

        [TestMethod]
        public void PascalCasedStringTest()
        {
            TestCamelCase("TestString", "testString");
        }

        [TestMethod]
        public void NonLatinStringsTest()
        {
            TestCamelCase("simple éxample", "simpleÉxample");
        }


        [TestMethod]
        public void LocaleTest()
        {
            string actual = "A STRING".CamelCase(CultureInfo.CreateSpecificCulture("tr"));
            Assert.AreEqual("aStrıng", actual);
        }

        
        private void TestCamelCase(string input, string expected)
        {
            string actual = input.CamelCase();
            Assert.AreEqual(expected, actual);
        }
    }
}
