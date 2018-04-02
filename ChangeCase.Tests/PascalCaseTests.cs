using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace All.ChangeCase.Tests
{
    [TestClass]
    public class PascalCaseTests
    {
        [TestMethod]
        public void SingleWordTest()
        {
            TestPascalCase("test", "Test");
            TestPascalCase("TEST", "Test");
        }


        [TestMethod]
        public void RegularSentenceCasedStringsTest()
        {
            TestPascalCase("test string", "TestString");
            TestPascalCase("Test String", "TestString");
        }

        [TestMethod]
        public void NonAlphanumericSeparatorsTest()
        {
            TestPascalCase("dot.case", "DotCase");
            TestPascalCase("path/case", "PathCase");
        }

        [TestMethod]
        public void UnderscorePeriodsInsideNumbersTest()
        {
            TestPascalCase("version 1.2.10", "Version1_2_10");
            TestPascalCase("version 1.21.0", "Version1_21_0");
        }

        [TestMethod]
        public void PascalCasedStringTest()
        {
            TestPascalCase("TestString", "TestString");
        }

        [TestMethod]
        public void NonLatinStringsTest()
        {
            TestPascalCase("simple éxample", "SimpleÉxample");
        }


        [TestMethod]
        public void LocaleTest()
        {
            string actual = "my STRING".PascalCase(CultureInfo.CreateSpecificCulture("tr"));
            Assert.AreEqual("MyStrıng", actual);
        }

        private void TestPascalCase(string input, string expected)
        {
            string actual = input.PascalCase();
            Assert.AreEqual(expected, actual);
        }
    }
}
