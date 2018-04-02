using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace All.ChangeCase.Tests
{
    [TestClass]
    public class DotCaseTests
    {
        [TestMethod]
        public void NullInputTest()
        {
            TestDotCase(null, "");
        }

        [TestMethod]
        public void NumberInputTest()
        {
            TestDotCase("10", "10");
        }

        [TestMethod]
        public void SingleWordTest()
        {
            TestDotCase("test", "test");
            TestDotCase("TEST", "test");
        }

        [TestMethod]
        public void CamelCaseTest()
        {
            TestDotCase("testString", "test.string");
            TestDotCase("testString123", "test.string.123");
        }

        [TestMethod]
        public void NonAlphaNumericSeparatorsTest()
        {
            TestDotCase("dot.case", "dot.case");
            TestDotCase("path/case", "path.case");
            TestDotCase("snake_case", "snake.case");
        }

        [TestMethod]
        public void PunctuationTest()
        {
            TestDotCase("\"quotes\"", "quotes");
        }

        [TestMethod]
        public void SpaceBetweenNumberPartsTest()
        {
            TestDotCase("version 0.45.0", "version.0.45.0");
            TestDotCase("version 0..78..9", "version.0.78.9");
            TestDotCase("version 4_99/4", "version.4.99.4");
        }


        [TestMethod]
        public void WhitespaceTest()
        {
            TestDotCase("  test  ", "test");
        }

        [TestMethod]
        public void NonAsciiChacterTest()
        {
            // Non-ascii characters.
            TestDotCase("español", "español");
            TestDotCase("Beyoncé Knowles", "beyoncé.knowles");
            TestDotCase("Iñtërnâtiônàlizætiøn", "iñtërnâtiônàlizætiøn");
        }

        [TestMethod]
        public void NumberStringInput()
        {
            // Number string input.
            TestDotCase("something2014other", "something.2014.other");
        }



       

        [TestMethod]
        public void CustomLocaletest()
        {
            string actual = "A STRING".DotCase(CultureInfo.CreateSpecificCulture("tr"));
            Assert.AreEqual("a.strıng", actual);
        }


        private void TestDotCase(string input, string expected )
        {
            string actual = input.DotCase();
            Assert.AreEqual(expected, actual);
        }
     
    }
}
