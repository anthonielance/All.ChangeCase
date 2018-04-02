using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace All.ChangeCase.Tests
{
    [TestClass]
    public class TitleCaseTests
    {
        

        [TestMethod]
        public void SingleWordTest()
        {
            TestTitleCase("test", "Test");
            TestTitleCase("TEST", "Test");
        }

        [TestMethod]
        public void RegularSentenceTest()
        {
            TestTitleCase("test string", "Test String");
            TestTitleCase("Test String", "Test String");
        }

        [TestMethod]
        public void NonAlphanumericSeparatorTest()
        {
            TestTitleCase("dot.case", "Dot Case");
            TestTitleCase("path/case", "Path Case");
        }

        [TestMethod]
        public void PascalCasedStringsTest()
        {
            TestTitleCase("TestString", "Test String");
            TestTitleCase("TestString1_2_3", "Test String 1 2 3");
        }


        [TestMethod]
        public void CamelCasedStringsTest()
        {
            TestTitleCase("testString", "Test String");
        }

        [TestMethod]
        public void NonAsciiSupportTest()
        {
            TestTitleCase("éxample", "Éxample");
        }

        private void TestTitleCase(string input, string expected)
        {
            var actual = input.TitleCase();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TurkishTest()
        {
            string actual = "STRING".TitleCase(CultureInfo.CreateSpecificCulture("tr"));
            Assert.AreEqual("Strıng", actual);
        }
    }
}
